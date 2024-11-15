﻿// <auto-generated />
using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(TiendaRopaContext))]
    partial class TiendaRopaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Model.Cargas.Carga", b =>
                {
                    b.Property<int>("IdUsu")
                        .HasColumnType("int");

                    b.Property<int>("IdOperacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdOperacion"));

                    b.Property<string>("EstadoOperacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FecOperacion")
                        .HasColumnType("datetime2");

                    b.HasKey("IdUsu", "IdOperacion");

                    b.ToTable("Cargas");
                });

            modelBuilder.Entity("Domain.Model.Cargas.LineaCarga", b =>
                {
                    b.Property<int>("IdUsu")
                        .HasColumnType("int");

                    b.Property<int>("IdOperacion")
                        .HasColumnType("int");

                    b.Property<int>("NumeroLinea")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NumeroLinea"));

                    b.Property<int>("CantidadPrenda")
                        .HasColumnType("int");

                    b.Property<int>("IdPrenda")
                        .HasColumnType("int");

                    b.HasKey("IdUsu", "IdOperacion", "NumeroLinea");

                    b.HasIndex("IdPrenda");

                    b.ToTable("LineasCarga");
                });

            modelBuilder.Entity("Domain.Model.Compras.Bonificacion", b =>
                {
                    b.Property<int>("IdBonificacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBonificacion"));

                    b.Property<decimal>("CantidadParaDescuento")
                        .HasColumnType("decimal(18,0)");

                    b.Property<DateTime>("FecVigenciaBonificacion")
                        .HasColumnType("datetime2");

                    b.Property<float>("ProporcionDescuento")
                        .HasColumnType("real");

                    b.HasKey("IdBonificacion");

                    b.ToTable("Bonificaciones");
                });

            modelBuilder.Entity("Domain.Model.Compras.Compra", b =>
                {
                    b.Property<int>("IdUsu")
                        .HasColumnType("int");

                    b.Property<int>("IdOperacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdOperacion"));

                    b.Property<string>("EstadoOperacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FecOperacion")
                        .HasColumnType("datetime2");

                    b.HasKey("IdUsu", "IdOperacion");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("Domain.Model.Compras.LineaCompra", b =>
                {
                    b.Property<int>("IdUsu")
                        .HasColumnType("int");

                    b.Property<int>("IdOperacion")
                        .HasColumnType("int");

                    b.Property<int>("NumeroLinea")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NumeroLinea"));

                    b.Property<int>("CantidadPrenda")
                        .HasColumnType("int");

                    b.Property<int>("IdPrenda")
                        .HasColumnType("int");

                    b.HasKey("IdUsu", "IdOperacion", "NumeroLinea");

                    b.HasIndex("IdPrenda");

                    b.ToTable("LineasCompra");
                });

            modelBuilder.Entity("Domain.Model.Prendas.Marca", b =>
                {
                    b.Property<int>("IdMarca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMarca"));

                    b.Property<string>("DescripcionMarca")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdMarca");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("Domain.Model.Prendas.PrecioPrenda", b =>
                {
                    b.Property<int>("IdPrenda")
                        .HasColumnType("int");

                    b.Property<DateTime>("FecVigencia")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,0)");

                    b.HasKey("IdPrenda", "FecVigencia");

                    b.ToTable("PreciosPrenda");
                });

            modelBuilder.Entity("Domain.Model.Prendas.Prenda", b =>
                {
                    b.Property<int>("IdPrenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPrenda"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdMarca")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPrenda")
                        .HasColumnType("int");

                    b.Property<int>("PuntoPedido")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("Talla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPrenda");

                    b.HasIndex("IdMarca");

                    b.HasIndex("IdTipoPrenda");

                    b.ToTable("Prendas");
                });

            modelBuilder.Entity("Domain.Model.Prendas.TipoPrenda", b =>
                {
                    b.Property<int>("IdTipoPrenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoPrenda"));

                    b.Property<string>("DescripcionTipoPrenda")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdTipoPrenda");

                    b.ToTable("TiposPrenda");
                });

            modelBuilder.Entity("Domain.Model.Usuarios.Usuario", b =>
                {
                    b.Property<int>("IdUsu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsu"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Contrasenia")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("FecNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("MedioDePago")
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TipoUsuario")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdUsu");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Domain.Model.Cargas.Carga", b =>
                {
                    b.HasOne("Domain.Model.Usuarios.Usuario", "Usuario")
                        .WithMany("Cargas")
                        .HasForeignKey("IdUsu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Model.Cargas.LineaCarga", b =>
                {
                    b.HasOne("Domain.Model.Prendas.Prenda", "Prenda")
                        .WithMany("LineasCarga")
                        .HasForeignKey("IdPrenda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Model.Cargas.Carga", "Carga")
                        .WithMany("LineasCarga")
                        .HasForeignKey("IdUsu", "IdOperacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carga");

                    b.Navigation("Prenda");
                });

            modelBuilder.Entity("Domain.Model.Compras.Compra", b =>
                {
                    b.HasOne("Domain.Model.Usuarios.Usuario", "Usuario")
                        .WithMany("Compras")
                        .HasForeignKey("IdUsu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Model.Compras.LineaCompra", b =>
                {
                    b.HasOne("Domain.Model.Prendas.Prenda", "Prenda")
                        .WithMany("LineasCompra")
                        .HasForeignKey("IdPrenda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Model.Compras.Compra", "Compra")
                        .WithMany("LineasCompra")
                        .HasForeignKey("IdUsu", "IdOperacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compra");

                    b.Navigation("Prenda");
                });

            modelBuilder.Entity("Domain.Model.Prendas.PrecioPrenda", b =>
                {
                    b.HasOne("Domain.Model.Prendas.Prenda", "Prenda")
                        .WithMany("PreciosPrenda")
                        .HasForeignKey("IdPrenda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prenda");
                });

            modelBuilder.Entity("Domain.Model.Prendas.Prenda", b =>
                {
                    b.HasOne("Domain.Model.Prendas.Marca", "MarcaPrenda")
                        .WithMany("Prendas")
                        .HasForeignKey("IdMarca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Model.Prendas.TipoPrenda", "TipoDePrenda")
                        .WithMany("Prendas")
                        .HasForeignKey("IdTipoPrenda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MarcaPrenda");

                    b.Navigation("TipoDePrenda");
                });

            modelBuilder.Entity("Domain.Model.Cargas.Carga", b =>
                {
                    b.Navigation("LineasCarga");
                });

            modelBuilder.Entity("Domain.Model.Compras.Compra", b =>
                {
                    b.Navigation("LineasCompra");
                });

            modelBuilder.Entity("Domain.Model.Prendas.Marca", b =>
                {
                    b.Navigation("Prendas");
                });

            modelBuilder.Entity("Domain.Model.Prendas.Prenda", b =>
                {
                    b.Navigation("LineasCarga");

                    b.Navigation("LineasCompra");

                    b.Navigation("PreciosPrenda");
                });

            modelBuilder.Entity("Domain.Model.Prendas.TipoPrenda", b =>
                {
                    b.Navigation("Prendas");
                });

            modelBuilder.Entity("Domain.Model.Usuarios.Usuario", b =>
                {
                    b.Navigation("Cargas");

                    b.Navigation("Compras");
                });
#pragma warning restore 612, 618
        }
    }
}
