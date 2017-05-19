using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    [Table("Nacionalidades")]
    public class Nacionalidad
    {
        [Key]
        public int Nacionalidadid { get; set; }



    }
}
