using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    public class Venta
    {
        public int ventaid { get; set; }
        public List<Libro> Libros_Vendidos { get; set; }
        public double MontoTotal { get; set; }
        public DateTime Fecha_Transaccion { get; set; }
        public char Modo_recojo { get; set; }
        public char Estado { get; set; }
        public Cliente Nombre_C { get; set; }
    }
}
