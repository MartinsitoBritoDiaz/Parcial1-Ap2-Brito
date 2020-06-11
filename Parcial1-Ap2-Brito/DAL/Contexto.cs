using Microsoft.EntityFrameworkCore;
using Parcial1_Ap2_Brito.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_Ap2_Brito.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> Articulo { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA/Articulos.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
