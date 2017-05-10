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

        public Cliente Cliente { get; set; }

        public Comprobante()
        {

        }
        public Comprobante(int comprobanteId, Venta venta, Cliente cliente)
        {
            Comprobanteid = comprobanteId;
            Venta = venta;
            Cliente = cliente;

        }


    }
}
