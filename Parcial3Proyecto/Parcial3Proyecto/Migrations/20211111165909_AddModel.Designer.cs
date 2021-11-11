﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial3Proyecto.Data;

namespace Parcial3Proyecto.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211111165909_AddModel")]
    partial class AddModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Parcial3Proyecto.Models.Usuario", b =>
                {
                    b.Property<string>("Almacen")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Costo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Producto")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("link")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Almacen");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}