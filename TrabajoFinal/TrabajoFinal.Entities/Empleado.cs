using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    [Table("Empleados")]
    public class Empleado
    {
        [Key]
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
