using Domain.Model.Compras;
using ProgramaPrincipal;
using OperacionService;

namespace Domain.Services
{
    public class CompraService : OperacionService
    {
        public override void Add(Compra compra)
        {
            using var context = new TiendaRopaContext();

            context.Compras.Add(compra);
            context.SaveChanges();
        }

        public override void Update(Compra compra)
        {
            base.Update(compra);
            using var context = new TiendaRopaContext();

            Compra? compraToUpdate = context.Compras.Find(compra.IdCompra);

            if (compraToUpdate != null)
            {
                compraToUpdate.Cliente = compra.Cliente;
                context.SaveChanges();
            }
        }

        public override void Delete(int idCompra)
        {
            using var context = new TiendaRopaContext();

            Compra? compraToDelete = context.Compras.Find(compra.IdCompra);

            if (compraToDelete != null)
            {
                context.Compras.Remove(compraToDelete);
                context.SaveChanges();
            }
        }

        public override Compra? GetOne(int idCompra)
        {
            using var context = new TiendaRopaContext();
            return context.Compras.Find(IdCompra);
        }

        public override IEnumerable<Compra> FindAll()
        {
            using var context = new TiendaRopaContext();
            return context.Compras.ToList();
        }
    }
}