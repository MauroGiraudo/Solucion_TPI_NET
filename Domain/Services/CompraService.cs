using Domain.Model.Compras;

namespace Domain.Services
{
    public class CompraService
    {
        public  void Add(Compra compra)
        {
            using var context = new TiendaRopaContext();

            context.Compras.Add(compra);
            context.SaveChanges();
        }

        public  void Update(Compra compra)
        {
            using var context = new TiendaRopaContext();

            Compra? compraToUpdate = context.Compras.Find(compra.IdOperacion);

            if (compraToUpdate != null)
            {
                compraToUpdate.FecOperacion = compra.FecOperacion;
                compraToUpdate.EstadoOperacion = compra.EstadoOperacion;
                compraToUpdate.Cliente = compra.Cliente;
                context.SaveChanges();
            }
        }

        public  void Delete(int IdOperacion)
        {
            using var context = new TiendaRopaContext();

            Compra? compraToDelete = context.Compras.Find(IdOperacion);

            if (compraToDelete != null)
            {
                context.Compras.Remove(compraToDelete);
                context.SaveChanges();
            }
        }

        public  Compra? GetOne(int IdOperacion)
        {
            using var context = new TiendaRopaContext();
            return context.Compras.Find(IdOperacion);
        }

        public  IEnumerable<Compra> FindAll()
        {
            using var context = new TiendaRopaContext();
            return context.Compras.ToList();
        }
    }
}