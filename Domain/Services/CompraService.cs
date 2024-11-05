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

        public  void Delete(Compra compra)
        {
            using var context = new TiendaRopaContext();

            context.Compras.Remove(compra);
            context.SaveChanges();
        }

        public  Compra? GetOne(int IdUsu, int IdOperacion)
        {
            using var context = new TiendaRopaContext();
            return context.Compras.Find(IdUsu, IdOperacion);
        }

        public  IEnumerable<Compra> FindAll(int IdUsu)
        {
            using var context = new TiendaRopaContext();
            var compras = context.Compras.ToList();
            return from c in compras
                   where c.IdUsu == IdUsu
                   select c;
        }
    }
}