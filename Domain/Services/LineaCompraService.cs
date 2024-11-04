using Domain.Model.Compras;

namespace Domain.Services
{
    public class LineaCompraService
    {
        public void Add(LineaCompra lineaCompra)
        {
            using var context = new TiendaRopaContext();

            context.LineasCompra.Add(lineaCompra);
            context.SaveChanges();
        }

        public void Update(LineaCompra lineaCompra)
        {
            using var context = new TiendaRopaContext();

            LineaCompra? lineaCompraToUpdate = context.LineasCompra.Find(lineaCompra.NumeroLinea, lineaCompra.Compra.IdOperacion);

            if (lineaCompraToUpdate != null)
            {
                lineaCompraToUpdate.CantidadPrenda = lineaCompra.CantidadPrenda;
                lineaCompraToUpdate.Prenda = lineaCompra.Prenda;
                lineaCompraToUpdate.Compra = lineaCompra.Compra;
                context.SaveChanges();
            }
        }

        public void Delete(LineaCompra lineaCompra)
        {
            using var context = new TiendaRopaContext();

            context.LineasCompra.Remove(lineaCompra);
            context.SaveChanges();
        }

        public LineaCompra? GetOne(int NumeroLinea, int IdOperacion)
        {
            using var context = new TiendaRopaContext();
            return context.LineasCompra.Find(NumeroLinea, IdOperacion);
        }

        public IEnumerable<LineaCompra> FindAll()
        {
            using var context = new TiendaRopaContext();
            return context.LineasCompra.ToList();
        }
    }
}