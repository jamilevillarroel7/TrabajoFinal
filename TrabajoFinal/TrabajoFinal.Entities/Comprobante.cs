using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    public class Comprobante
    {
        public int comprobanteid { get; set; }
        public int fecha { get; set; }
        public double precioTotal { get; set; }
        public int clienteid { get; set; }


    }
}
