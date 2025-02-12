﻿// <auto-generated />
using System;
using CRUD_NetCore5.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD_NetCore5.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220512134652_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("CRUD_NetCore5.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("autor");

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("dataLancamento");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("descricao");

                    b.Property<int>("Preco")
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasColumnName("preco");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("titulo");

                    b.HasKey("Id");

                    b.ToTable("Livros");
                });
#pragma warning restore 612, 618
        }
    }
}
