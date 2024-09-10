using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acceso_datos
{
    public class CategoryMapper : IDBMapper<Categoria>
    {
        public string mapFromObject(Categoria obj)
        {
            return obj.ToString();
        }

        public Categoria mapToObject(SqlDataReader reader)
        {
            Categoria cat = new Categoria();

            cat.Id = reader.GetInt32(0);
            cat.Descripcion = reader.GetString(1);

            return cat;
        }
    }
}
