using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    public class Cliente
    {
        public int Clienteid { get; set; }

        public Carrito Carrito { get; set; }

        public List<Libro> Libros { get; set; }

    }
}
