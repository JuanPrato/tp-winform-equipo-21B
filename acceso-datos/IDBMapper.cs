using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acceso_datos
{
    public interface IDBMapper<T>
    {
        T mapToObject(SqlDataReader reader);
        string mapFromObject(T obj);
    }
}
