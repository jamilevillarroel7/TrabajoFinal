using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    public class Libro
    {
        public string Libroid { get; set; }

        public TipoLibro TipoLibro { get; set; }
        public Categoria Categoria { get; set; }
        public Autor Autor { get; set; }
    }
}
