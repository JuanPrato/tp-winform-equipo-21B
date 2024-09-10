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
        private List<string> rows;
        private SqlConnection sqlConexion = new SqlConnection();
        private SqlDataReader reader;
        private IDBMapper<T> mapper;

        public Bussiness(string tableName, List<string> rows, IDBMapper<T> mapper)
        {
            this.rows = rows;
            this.mapper = mapper;
            this.tableName = tableName;

            SqlConnectionStringBuilder sConnB = new SqlConnectionStringBuilder()
            {
                DataSource = "localhost",
                InitialCatalog = "CATALOGO_P3_DB",
                IntegratedSecurity = true
            };

            //sqlConexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
            sqlConexion.ConnectionString = sConnB.ConnectionString;
        }

        protected List<T> getByConditions()
        {
            return new List<T>();
        }

        public List<T> getAll()
        {
            SqlCommand command = new SqlCommand();

            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT " + String.Join(" ,", rows) + " FROM " + tableName;
            command.Connection = sqlConexion;

            sqlConexion.Open();

            reader = command.ExecuteReader();

            List<T> list = new List<T>();

            while (reader.Read())
            {
                list.Add(this.mapper.mapToObject(reader));
            }

            sqlConexion.Close();

            return list;
        }

        public T getOne(T id)
        {
            return id;
        }

        public void deleteOne(int id)
        {

        }

        public bool saveOne(T item)
        {
            return true;
        }
    }
}
