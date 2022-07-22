﻿// <auto-generated />
using Fiap.Smart.City.Projeto.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fiap.Smart.City.Projeto.Migrations
{
    [DbContext(typeof(ProdutoContext))]
    [Migration("20220722130207_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Fiap.Smart.City.Projeto.Models.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Caracteristicas")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LogoTipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("PrecoMedio")
                        .HasColumnType("double");

                    b.Property<int>("TipoIdTipo")
                        .HasColumnType("int");

                    b.HasKey("IdProduto");

                    b.HasIndex("TipoIdTipo");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("Fiap.Smart.City.Projeto.Models.TipoProduto", b =>
                {
                    b.Property<int>("IdTipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Comercializado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("DescricaoTipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdTipo");

                    b.ToTable("tiposProdutos");
                });

            modelBuilder.Entity("Fiap.Smart.City.Projeto.Models.Produto", b =>
                {
                    b.HasOne("Fiap.Smart.City.Projeto.Models.TipoProduto", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoIdTipo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo");
                });
#pragma warning restore 612, 618
        }
    }
}
