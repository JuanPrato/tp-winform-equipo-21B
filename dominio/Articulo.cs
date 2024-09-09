using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public string Codigo { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca IdMarca { get; set; }
        public Categoria IdCategoria { get; set; }
        //public Urlimagen list<Urlimagen>
        public decimal Precio { get; set; }
    }
}
