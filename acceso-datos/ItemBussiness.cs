using System;
using System.Collections.Generic;
using dominio;

namespace acceso_datos
{
    public class ItemBussiness : Bussiness<Articulo>
    {
        public ItemBussiness() : base("ARTICULOS", "Codigo", new List<string> { "Descripcion" }, new ItemMapper())
        {
        }
    }
}
