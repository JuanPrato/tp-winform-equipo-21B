using dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acceso_datos
{
    public class ItemMapper : IDBMapper<Articulo>
    {
        public string mapFromObject(Articulo obj)
        {
            return obj.ToString();
        }

        public Articulo mapToObject(SqlDataReader reader)
        {
            Articulo art = new Articulo();

            art.Codigo = reader.GetString(1);
            art.Nombre = reader.GetString(2);
            art.Descripcion = reader.GetString(3);
            art.Marca = new Marca();
            art.Marca.Id = reader.GetInt32(4);
            art.Categoria = new Categoria();
            art.Categoria.Id = reader.GetInt32(5);
            art.Precio = reader.GetDecimal(6);
            art.Urls = (from IDataRecord r in reader select (string)r["Urls"]).ToList();

            return art;
        }
    }
}
