using System;
using Fiap.Smart.City.Projeto.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore;



namespace Fiap.Smart.City.Projeto.Repositorio
{
    public class ProdutoContext : DbContext
    {

        public DbSet<Produto> produtos { get; set; }
        public DbSet<TipoProduto> tiposProdutos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasKey(p => p.IdProduto);

            modelBuilder.Entity<TipoProduto>()
                .HasKey(p => p.IdTipo);


            //base.OnModelCreating(modelBuilder);
        }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Server=< servidor, geralmente é localhost>;Database=<o nome do banco que você quer criar>;Uid=<colocar o usuário do seu banco>;Pwd=<colocar a senha do seu banco de dados>;";
            optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
