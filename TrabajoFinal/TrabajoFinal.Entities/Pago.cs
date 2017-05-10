using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    public class Pago
    {

        public int Pagoid { get; set; }

        public TipoPago TipoPago { get; set; }

        public Pago(int pagoId, TipoPago tipoPago)
        {
            Pagoid = pagoId;
            TipoPago = tipoPago;

        }

    }
}
