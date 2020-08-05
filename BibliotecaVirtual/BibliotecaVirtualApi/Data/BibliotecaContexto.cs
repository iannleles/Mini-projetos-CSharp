using BibliotecaVirtualApi.Data.Mapeamentos;
using BibliotecaVirtualApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaVirtualApi.Data
{
    public class BibliotecaContexto : DbContext 
    {
        public BibliotecaContexto(DbContextOptions<BibliotecaContexto> options)
            : base(options) { }

        public DbSet<Editora> Editoras { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new EditoraMap());
            
             
        }
    }
}
