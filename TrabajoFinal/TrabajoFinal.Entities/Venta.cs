using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    public class Venta
    {
        public int Ventaid { get; set; }
        public List<Libro> Libros_Vendidos { get; set; }


        public Cliente Nombre_C { get; set; }

        public Pago Pago { get; set; }

        public Envio Envio { get; set; }


    }
}
