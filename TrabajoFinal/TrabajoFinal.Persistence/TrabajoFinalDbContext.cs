using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoFinal.Entities;

namespace TrabajoFinal.Persistence
{
    public class TrabajoFinalDbContext : DbContext
    {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Carrito> Carritos { get; set; }
    }
}
