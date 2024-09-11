using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acceso_datos
{
    public class BrandMapper : IDBMapper<Marca>
    {
        public string mapFromObject(Marca obj)
        {
            return obj.ToString();
        }

        public Marca mapToObject(SqlDataReader reader)
        {
            Marca mar = new Marca();

            mar.Id = reader.GetInt32(0);
            mar.Descripcion = reader.GetString(1);

            return mar;
        }
    }
}
