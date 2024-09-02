using Microsoft.EntityFrameworkCore;
using Clases.Usuarios;
using Clases.Prendas;
using Clases.Compras;
using Clases.Cargas;

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
            optionsBuilder.UseSqlServer(@"Server=MAUROG;Initial Catalog=Tienda_Ropa;Integrated Security=true;Trusted_Connection=true;TrustServerCertificate=True");
        }

        public TiendaRopaContext()
        {
            this.Database.EnsureCreated();
        }
    }
}