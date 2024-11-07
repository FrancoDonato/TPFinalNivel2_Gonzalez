using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Articulos
    {
        public int codArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Marca { get; set; }
        public string Categoria { get; set; }
        public string URLimagen { get; set; }
        public float Precio { get; set; }
    }
}
