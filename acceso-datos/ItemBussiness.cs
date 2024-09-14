using System;
using System.Collections.Generic;
using System.Data.Common;
using dominio;

namespace acceso_datos
{
    public class ItemBussiness : Bussiness<Articulo>
    {

        private static List<string> columns = new List<string> { "Codigo", "Nombre", "Descripcion", "IdMarca", "IdCategoria", "Precio" };

        public ItemBussiness() : base("ARTICULOS", "Id", columns, new ItemMapper())
        {
        }
        override public List<Articulo> getAll()
        {


            return base.select(
                $"t.{idColumn}, t.{String.Join(" ,t.", columns)}, c.Descripcion as CatDescription, m.Descripcion as MarDescription",
                "INNER JOIN CATEGORIAS c ON c.Id=IdCategoria " +
                "INNER JOIN MARCAS m ON m.Id=IdMarca"
                );
        }

        public List<Articulo> getAllFilterByName(string query)
        {
            return this.getAllFilterByTextContain(1, query);
        }
    }
}
