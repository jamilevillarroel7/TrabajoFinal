using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    public class Empleado
    {
        public string empleadoid { get; set; }
        public string Nombre { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public int Telefono { get; set; }
        public char Sexo { get; set; }
        public DateTime fechaRegistro { get; set; }
        public char Estado { get; set; }
        public string Direccion { get; set; }
        public string email { get; set; }

    }
}
