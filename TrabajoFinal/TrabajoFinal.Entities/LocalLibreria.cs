using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    public class LocalLibreria
    {
        public int Localid { get; set; }

        public Empleado Empleado { get; set; }

        public LocalLibreria()
        {

        }

        public LocalLibreria(int localId, Empleado empleado)
        {
            Localid = localId;
            Empleado = empleado;

        }
    }
}
