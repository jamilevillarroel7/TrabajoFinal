using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    public class Libreria
    {
        public int Libreriaid { get; set; }

        public List<LocalLibreria> LocalLibrerias { get; set; }

        public List<Empleado> Empleados { get; set; }

        public Libreria()
        {
            LocalLibrerias = new List<LocalLibreria>();
            Empleados = new List<Empleado>();
        }

        public Libreria(int empleadoId, int localLibreria, int libreriaId)
        {
            Libreriaid = libreriaId;

            LocalLibrerias = new List<LocalLibreria>(localLibreria);
            Empleados = new List<Empleado>(empleadoId);


        }

    }
}
