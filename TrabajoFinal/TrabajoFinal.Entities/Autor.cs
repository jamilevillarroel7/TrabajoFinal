using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    [Table("Autores")]
    public class Autor
    {
        [Key]
        public int Autorid { get; set; }
        public Nacionalidad Nacionalidad { get; set; }

        public Autor()
        {
        }
        public Autor(Nacionalidad nacionalidad)
        {
            Nacionalidad = nacionalidad;

        }
    }
}
