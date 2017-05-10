using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
   public class Carrito
    {
        public int carritoid { get; set; }
        public string correo { get; set; }
        public double precio { get; set; }
        public string estado { get; set; }
        public int stock { get; set; }
        public DateTime añoPublicacion { get; set; }
        public string valoracion { get; set; }

    }
}
