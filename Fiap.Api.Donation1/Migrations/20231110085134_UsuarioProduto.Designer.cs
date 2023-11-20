﻿// <auto-generated />
using System;
using Fiap.Api.Donation1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fiap.Api.Donation1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231110085134_UsuarioProduto")]
    partial class UsuarioProduto
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fiap.Api.Donation1.Models.ProdutoModel", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdutoId"));

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataExpiracao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SugestaoTroca")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TipoProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("ProdutoId");

                    b.HasIndex("TipoProdutoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Fiap.Api.Donation1.Models.TipoProdutoModel", b =>
                {
                    b.Property<int>("TipoProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoProdutoId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NomeTipoProduto")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("TipoProdutoId");

                    b.ToTable("TipoProduto");

                    b.HasData(
                        new
                        {
                            TipoProdutoId = 1,
                            Descricao = "Descriçao para celular",
                            NomeTipoProduto = "Celular"
                        },
                        new
                        {
                            TipoProdutoId = 2,
                            Descricao = "Descriçao para Tvs",
                            NomeTipoProduto = "Tvs"
                        },
                        new
                        {
                            TipoProdutoId = 3,
                            Descricao = "Descriçao para ar-condicionado",
                            NomeTipoProduto = "Ar-condicionado"
                        });
                });

            modelBuilder.Entity("Fiap.Api.Donation1.Models.UsuarioModel", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("EmailUsuario")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Regra")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            EmailUsuario = "sa@fiap.com.br",
                            NomeUsuario = "Super Admin",
                            Regra = "admin",
                            Senha = "123456"
                        },
                        new
                        {
                            UsuarioId = 2,
                            EmailUsuario = "joao@fiap.com.br",
                            NomeUsuario = "Joao",
                            Regra = "admin",
                            Senha = "123456"
                        },
                        new
                        {
                            UsuarioId = 3,
                            EmailUsuario = "flavio@fiap.com.br",
                            NomeUsuario = "Flavio",
                            Regra = "admin",
                            Senha = "123456"
                        });
                });

            modelBuilder.Entity("Fiap.Api.Donation1.Models.ProdutoModel", b =>
                {
                    b.HasOne("Fiap.Api.Donation1.Models.TipoProdutoModel", "TipoProduto")
                        .WithMany()
                        .HasForeignKey("TipoProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fiap.Api.Donation1.Models.UsuarioModel", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoProduto");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
