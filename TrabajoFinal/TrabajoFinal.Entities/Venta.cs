using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    [Table("Ventas")]
    public class Venta
    {
        [Key]
        public int Ventaid { get; set; }

        public List<Libro> Libros_Vendidos { get; set; }
        public Cliente Cliente { get; set; }
        public Pago Pago { get; set; }
        public Envio Envio { get; set; }

        public Venta()
        {
            Libros_Vendidos = new List<Libro>();
        }

        public Venta(int ventaId, int idLibro, Cliente cliente, Pago pago, Envio envio)
        {
            Ventaid = ventaId;
            Libros_Vendidos = new List<Libro>(idLibro);
            Cliente = cliente;
            Pago = pago;
            Envio = envio;

        }


    }
}
