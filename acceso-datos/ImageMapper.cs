using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acceso_datos
{
    public class ImageMapper : IDBMapper<Imagen>
    {
        public string mapFromObject(Imagen obj)
        {
            return obj.ToString();
        }

        public Imagen mapToObject(SqlDataReader reader)
        {
            Imagen ima = new Imagen();

            ima.Id = reader.GetInt32(0);
            ima.Url = reader.GetString(1);

            return ima;
        }
    }
}
