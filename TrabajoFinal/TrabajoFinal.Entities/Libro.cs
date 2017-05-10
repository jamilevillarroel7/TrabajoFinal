using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    public class Libro
    {
        public int Libroid { get; set; }

        public TipoLibro TipoLibro { get; set; }
        public Categoria Categoria { get; set; }
        public Autor Autor { get; set; }

        public Libro()
        {
            TipoLibro = TipoLibro.NoDefinido;
            Categoria = Categoria.NoDefinido;
        }

        public Libro(int libroId, TipoLibro tipoLibro,Categoria categoria, Autor autor )
        {
            Libroid = libroId;
            TipoLibro = tipoLibro;
            Categoria = categoria;
            Autor = autor;

        }
    }
}
