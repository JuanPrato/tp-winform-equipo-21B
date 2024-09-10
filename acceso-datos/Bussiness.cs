using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acceso_datos
{
    public abstract class Bussiness<T>
    {
        private string tableName;
        private string idColumn;
        private List<string> rows;
        private SqlConnection sqlConexion = new SqlConnection();
        private SqlDataReader reader;
        private IDBMapper<T> mapper;

        public Bussiness(string tableName, string idColumn, List<string> rows, IDBMapper<T> mapper)
        {
            this.idColumn = idColumn;
            this.rows = rows;
            this.mapper = mapper;
            this.tableName = tableName;

            SqlConnectionStringBuilder sConnB = new SqlConnectionStringBuilder()
            {
                DataSource = "localhost",
                InitialCatalog = "CATALOGO_P3_DB",
                IntegratedSecurity = true
            };

            sqlConexion.ConnectionString = sConnB.ConnectionString;
        }

        protected List<T> getByConditions()
        {
            return new List<T>();
        }

        public List<T> getAll()
        {

            sqlConexion.Open();

            string query = String.Format("SELECT {0},{1} FROM {2}", idColumn, String.Join(" ,", rows), tableName);

            reader = executeCommand(query);

            List<T> list = new List<T>();

            while (reader.Read())
            {
                list.Add(this.mapper.mapToObject(reader));
            }

            sqlConexion.Close();

            return list;
        }

        public T getOne(string id)
        {

            sqlConexion.Open();

            string query = String.Format("SELECT {0},{1} FROM {2} WHERE {3}={4}", idColumn, String.Join(" ,", rows), tableName, idColumn, id);

            SqlDataReader reader = this.executeCommand(query);

            if (!reader.Read())
            {
                throw new Exception();
            }

            T response = this.mapper.mapToObject(reader);

            sqlConexion.Close();

            return response;

        }

        public void deleteOne(string id)
        {
            sqlConexion.Open();

            string query = String.Format("DELETE FROM {0} WHERE {2}={3}", tableName, idColumn, id);
            SqlDataReader reader = this.executeCommand(query);

            if (!reader.Read())
            {
                throw new Exception();
            }
            sqlConexion.Close();
        }

        public bool saveOne(T item)
        {
            sqlConexion.Open();

            string query = String.Format("INSERT INTO {0} ({1}) VALUES ({2})", tableName, String.Join(" ,", rows), this.mapper.mapFromObject(item));
            SqlDataReader reader = this.executeCommand(query);

            if (!reader.Read())
            {
                throw new Exception();
            }
            sqlConexion.Close();

            return true;
        }

        private SqlDataReader executeCommand(string sqlCommand)
        {
            SqlCommand command = new SqlCommand();

            command.CommandType = System.Data.CommandType.Text;
            command.Connection = sqlConexion;
            command.CommandText = sqlCommand;

            return command.ExecuteReader();
        }
    }
}
