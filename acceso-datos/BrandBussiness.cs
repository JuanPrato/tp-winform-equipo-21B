using dominio;
using System.Collections.Generic;

namespace acceso_datos
{
    public class BrandBussiness : Bussiness<Marca>
    {
        public BrandBussiness() : base("MARCAS", "Id", new List<string> { "Descripcion" } , new BrandMapper()) 
        {
        }
    }
}
