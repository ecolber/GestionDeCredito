﻿// <auto-generated />
using System;
using GestionDeCredito.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestionDeCredito.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestionDeCredito.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("FechaCreacion")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("GestionDeCredito.Models.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaPago")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdPrestamo")
                        .HasColumnType("int");

                    b.Property<double>("MontoPagado")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdPrestamo");

                    b.ToTable("Pago");
                });

            modelBuilder.Entity("GestionDeCredito.Models.Prestamo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("FechaCreacion")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<double>("Interes")
                        .HasColumnType("float");

                    b.Property<double>("Monto")
                        .HasColumnType("float");

                    b.Property<int>("Plazo")
                        .HasColumnType("int");

                    b.Property<double>("Saldo")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.ToTable("Prestamo");
                });

            modelBuilder.Entity("GestionDeCredito.Models.Pago", b =>
                {
                    b.HasOne("GestionDeCredito.Models.Prestamo", "Prestamo")
                        .WithMany()
                        .HasForeignKey("IdPrestamo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GestionDeCredito.Models.Prestamo", b =>
                {
                    b.HasOne("GestionDeCredito.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
