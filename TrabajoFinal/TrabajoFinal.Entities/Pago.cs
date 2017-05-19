using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    [Table("Pagos")]
    public class Pago
    {
        [Key]
        public int Pagoid { get; set; }

        public TipoPago TipoPago { get; set; }

        public Pago(int pagoId, TipoPago tipoPago)
        {
            Pagoid = pagoId;
            TipoPago = tipoPago;

        }

    }
}
