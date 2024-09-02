using Microsoft.EntityFrameworkCore;
using Domain.Model.Usuarios;
using Domain.Model.Prendas;
using Domain.Model.Compras;
using Domain.Model.Cargas;

namespace ProgramaPrincipal
{
    internal class TiendaRopaContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
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
            optionsBuilder.UseSqlServer(@"Server=.\\SQLEXPRESS;Initial Catalog=Tienda_Ropa;Integrated Security=true;Trusted_Connection=true;TrustServerCertificate=True");
        }

        public TiendaRopaContext()
        {
            this.Database.EnsureCreated();
        }
    }
}