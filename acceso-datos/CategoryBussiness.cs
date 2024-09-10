using dominio;
using System.Collections.Generic;

namespace acceso_datos
{
    public class CategoryBussiness : Bussiness<Categoria>
    {
        public CategoryBussiness() : base("CATEGORIAS", new List<string> { "Id", "Descripcion" } , new CategoryMapper())
        {

        }
    }
}
