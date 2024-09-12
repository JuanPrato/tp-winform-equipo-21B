using System;
using System.Collections.Generic;
using dominio;

namespace acceso_datos
{
    public class ItemBussiness : Bussiness<Articulo>
    {

        private static List<string> rows = new List<string> { "Codigo", "Nombre", "Descripcion", "IdMarca", "IdCategoria", "Precio" };

        public ItemBussiness() : base("ARTICULOS", "Id", rows, new ItemMapper())
        {
        }

        public List<Articulo> getAllFilterByName(string query)
        {
            return this.getAllFilterByTextContain(1, query);
        }
    }
}
