using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    [Table("Comprobantes")]
    public class Comprobante
    {
        [Key]
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
