using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    public class Libro
    {
        public string libroid { get; set; }
        public string Editorial { get; set; }
        public double Precio  { get; set; }
        public char Estado { get; set; }
        public int stock { get; set; }
        public int AñoPubli { get; set; }
        public double Valoracion { get; set; }
        public int NumeroPagina { get; set; }
    }
}
