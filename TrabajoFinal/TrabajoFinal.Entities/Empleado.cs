using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    public class Empleado
    {
        public int Empleadoid { get; set; }

        public TipoEmpleado TipoEmpleado { get; set; }

        public Empleado()
        {
            TipoEmpleado = TipoEmpleado.NoDefinido;
        }

        public Empleado(int empleadoId, TipoEmpleado tipoEmpleado)
        {
            Empleadoid = empleadoId;
            TipoEmpleado = tipoEmpleado;

        }

    }
}
