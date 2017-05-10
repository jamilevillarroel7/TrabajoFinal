using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    public class Comprobante
    {
        public int Comprobanteid { get; set; }

        public Venta Venta { get; set; }

        public Cliente Clientes { get; set; }


    }
}
