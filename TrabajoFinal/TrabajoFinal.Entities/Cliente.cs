using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    public class Cliente
    {
        public int clienteid { get; set; }
        public int Numero_Identi_C { get; set; }
        public string nombre_C { get; set; }
        public string apelPaterno_C { get; set; }
        public string apelMaterno { get; set; }
        public string Direccion_C { get; set; }
        public string Correo_C { get; set; }

    }
}
