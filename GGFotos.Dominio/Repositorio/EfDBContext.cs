using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGFotos.Dominio.Entidade;

namespace GGFotos.Dominio.Repositorio
{
    public class EfDBContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
 	         
            // REMOVE A PLURALIZAÇÃO DO ENTITY E FAZ O MAPEAMENTO MANUAL OBJETO > TABELA
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produto");
        }

    }
}
