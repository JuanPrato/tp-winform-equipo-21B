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
        public int Id {  get; set; }
        public string Codigo { get; set; }

        [DisplayName("Nombre")]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public Marca Marca { get; set; }

        public Categoria Categoria { get; set; }

        public decimal Precio { get; set; }

        public List<string> Urls { get; set; }
    }
}
