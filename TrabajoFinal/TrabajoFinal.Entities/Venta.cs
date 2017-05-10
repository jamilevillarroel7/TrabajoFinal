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
