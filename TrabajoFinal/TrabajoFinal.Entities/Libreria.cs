using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    public class Libreria
    {
        public string IdLibreria { get; set; }
        public int NumeroRUC { get; set; }
        public string Direccion_Of_Principal { get; set; }
        public int Telefono_Of_Principal { get; set; }

        public Empleado IdAdmin_Libreria { get; set; }

    }
}
