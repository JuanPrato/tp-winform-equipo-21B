using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
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

        override public int saveOne(Articulo art)
        {
            int id = base.saveOne(art);

            if (id == -1)
            {
                throw new Exception("Ocurrió un error inesperado");
            }

            ImageBussiness imageBussiness = new ImageBussiness();

            foreach (Imagen img in art.Urls)
            {
                img.IdArticulo = id;
                imageBussiness.saveOne(img);
            }

            return id;
        }

        public List<Articulo> getAllFilterByName(string query)
        {
            return this.getAllFilterByTextContain(1, query);
        }

        public override void deleteOne(Articulo item)
        {
            ImageBussiness imageBussiness = new ImageBussiness();

            if (item.Urls != null && item.Urls.Count > 0) { 
                imageBussiness.deleteMany(item.Urls);
            }

            base.deleteOne(item);
        }

    }
}
