﻿using Microsoft.EntityFrameworkCore;
using Domain.Model.Usuarios;
using Domain.Model.Prendas;
using Domain.Model.Compras;
using Domain.Model.Cargas;

namespace Domain
{
    public class TiendaRopaContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoPrenda> TiposPrenda { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Prenda> Prendas { get; set; }
        public DbSet<PrecioPrenda> PreciosPrenda { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<LineaCompra> LineasCompra { get; set; }
        public DbSet<Carga> Cargas { get; set; }
        public DbSet<LineaCarga> LineasCarga { get; set; }
        public DbSet<Bonificacion> Bonificaciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Definimos la cadena de conexión a la base de datos
            optionsBuilder.UseSqlServer(@"Server=MAUROG;Initial Catalog=Tienda_Ropa;Integrated Security=true;Trusted_Connection=true;TrustServerCertificate=True", 
                b => b.MigrationsAssembly("WebAPI")   
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Definimos los Id Autoincrementales de las entidades
            modelBuilder.Entity<Usuario>().Property(c => c.IdUsu).ValueGeneratedOnAdd();
            modelBuilder.Entity<TipoPrenda>().Property(tp => tp.IdTipoPrenda).ValueGeneratedOnAdd();
            modelBuilder.Entity<Marca>().Property(m => m.IdMarca).ValueGeneratedOnAdd();
            modelBuilder.Entity<Prenda>().Property(p => p.IdPrenda).ValueGeneratedOnAdd();
            modelBuilder.Entity<Compra>().Property(c => c.IdOperacion).ValueGeneratedOnAdd();
            modelBuilder.Entity<LineaCompra>().Property(lc => lc.NumeroLinea).ValueGeneratedOnAdd();
            modelBuilder.Entity<Carga>().Property(c => c.IdOperacion).ValueGeneratedOnAdd();
            modelBuilder.Entity<LineaCarga>().Property(lc => lc.NumeroLinea).ValueGeneratedOnAdd();
            modelBuilder.Entity<Bonificacion>().Property(b => b.IdBonificacion).ValueGeneratedOnAdd();

            //Definimos las columnas de tipo "float" como "decimal(18,0)"
            modelBuilder.Entity<PrecioPrenda>().Property(pp => pp.Valor).HasColumnType("decimal(18,0)");
            modelBuilder.Entity<Bonificacion>().Property(b => b.CantidadParaDescuento).HasColumnType("decimal(18,0)");

            //Definir las columnas de tipo "string" como "varchar(n)"
            modelBuilder.Entity<Usuario>().Property(c => c.Email).HasColumnType("varchar(50)");
            modelBuilder.Entity<Usuario>().Property(c => c.Nombre).HasColumnType("varchar(50)");
            modelBuilder.Entity<Usuario>().Property(c => c.Apellido).HasColumnType("varchar(50)");
            modelBuilder.Entity<Usuario>().Property(c => c.Contrasenia).HasColumnType("varchar(50)");
            modelBuilder.Entity<Usuario>().Property(c => c.Telefono).HasColumnType("varchar(50)");
            modelBuilder.Entity<Usuario>().Property(c => c.UserName).HasColumnType("varchar(50)");
            modelBuilder.Entity<Usuario>().Property(c => c.TipoUsuario).HasColumnType("varchar(8)");
            modelBuilder.Entity<Usuario>().Property(c => c.MedioDePago).HasColumnType("varchar(25)");

            //Defino las columnas de tipo "DateTime" como "Date"
            modelBuilder.Entity<Usuario>().Property(c => c.FecNacimiento).HasColumnType("date");
            //modelBuilder.Entity<PrecioPrenda>().Property(pp => pp.FecVigencia).HasColumnType("date");

            modelBuilder.Entity<TipoPrenda>().Property(tp => tp.DescripcionTipoPrenda).HasColumnType("varchar(50)");

            modelBuilder.Entity<Marca>().Property(m => m.DescripcionMarca).HasColumnType("varchar(50)");

            modelBuilder.Entity<Prenda>().Property(p => p.Descripcion).HasColumnType("varchar(50)");
            


            //Definimos las claves primarias compuestas
            modelBuilder.Entity<PrecioPrenda>().HasKey(pp => new { pp.IdPrenda, pp.FecVigencia });
            modelBuilder.Entity<LineaCompra>().HasKey(lc => new { lc.IdUsu, lc.IdOperacion, lc.NumeroLinea });
            modelBuilder.Entity<LineaCarga>().HasKey(lc => new { lc.IdUsu, lc.IdOperacion, lc.NumeroLinea });
            modelBuilder.Entity<Compra>().HasKey(c => new { c.IdUsu, c.IdOperacion });
            modelBuilder.Entity<Carga>().HasKey(c => new { c.IdUsu, c.IdOperacion });

            //Definimos las relaciones entre las tablas
            modelBuilder.Entity<Usuario>().HasMany(usu => usu.Compras).WithOne(com => com.Usuario).HasForeignKey(com => com.IdUsu);
            modelBuilder.Entity<Usuario>().HasMany(usu => usu.Cargas).WithOne(car => car.Usuario).HasForeignKey(car => car.IdUsu);
            modelBuilder.Entity<Compra>().HasMany(com => com.LineasCompra).WithOne(lc => lc.Compra).HasForeignKey(lc => new { lc.IdUsu, lc.IdOperacion });
            modelBuilder.Entity<Carga>().HasMany(car => car.LineasCarga).WithOne(lc => lc.Carga).HasForeignKey(lc => new { lc.IdUsu, lc.IdOperacion });
            modelBuilder.Entity<TipoPrenda>().HasMany(tp => tp.Prendas).WithOne(p => p.TipoDePrenda).HasForeignKey(p => p.IdTipoPrenda);
            modelBuilder.Entity<Marca>().HasMany(m => m.Prendas).WithOne(p => p.MarcaPrenda).HasForeignKey(p => p.IdMarca);
            modelBuilder.Entity<Prenda>().HasMany(p => p.PreciosPrenda).WithOne(pp => pp.Prenda).HasForeignKey(pp => pp.IdPrenda);
            modelBuilder.Entity<Prenda>().HasMany(p => p.LineasCompra).WithOne(lc => lc.Prenda).HasForeignKey(lc => lc.IdPrenda);
            modelBuilder.Entity<Prenda>().HasMany(p => p.LineasCarga).WithOne(lc => lc.Prenda).HasForeignKey(lc => lc.IdPrenda);
        }

        public TiendaRopaContext()
        {
            this.Database.EnsureCreated();
        }
    }
}