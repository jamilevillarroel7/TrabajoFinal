using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
   public class Carrito
    {
        public int Carritoid { get; set; }

        public Cliente Cliente { get; set; }

        public List<Libro> Libros { get; set; }

    }
}
