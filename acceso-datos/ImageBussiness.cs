using System;
using System.Collections.Generic;
using dominio;

namespace acceso_datos
{
    public class ImageBussiness : Bussiness<Imagen>
    {
        public ImageBussiness() : base("IMAGENES", "Id", new List<string> { "IdArticulo", "ImagenUrl" }, new ImageMapper())
        {
        }
    }
}
