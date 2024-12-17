using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using QueVistoHoje.GestaoDeLoja.Data.Entities;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace QueVistoHoje.GestaoDeLoja.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Registo> Registos { get; set; }
        public DbSet<Encomenda> Encomendas { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            base.OnModelCreating(modelBuilder);

            //Configurações adicionais (exemplo: relacionamentos)
            modelBuilder.Entity<Categoria>()
                .HasOne(c => c.CategoriaPai)
                .WithMany(c => c.Subcategorias)
                .HasForeignKey(c => c.CategoriaPaiId);

        }
        //public DbSet<QueVistoHoje.GestaoDeLoja.Data.Entities.Empresa> Empresa { get; set; } = default!;
    }
}

