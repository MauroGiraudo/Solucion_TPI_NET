using Domain.Model.Compras;
using Microsoft.EntityFrameworkCore;

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

        /*public void Update(LineaCompra lineaCompra)
        {
            using var context = new TiendaRopaContext();

            LineaCompra? lineaCompraToUpdate = context.LineasCompra.Find(lineaCompra.NumeroLinea, lineaCompra.IdOperacion, lineaCompra.IdUsu);

            if (lineaCompraToUpdate != null)
            {
                lineaCompraToUpdate.CantidadPrenda = lineaCompra.CantidadPrenda;
                context.SaveChanges();
            }
        }*/

        public void Update(LineaCompra lineaCompra)
        {
            using var context = new TiendaRopaContext();

            context.Entry(lineaCompra).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(LineaCompra lineaCompra)
        {
            using var context = new TiendaRopaContext();

            context.LineasCompra.Remove(lineaCompra);
            context.SaveChanges();
        }

        public LineaCompra? GetOne(int IdUsu, int IdOperacion, int NumeroLinea)
        {
            using var context = new TiendaRopaContext();
            return context.LineasCompra.Find(IdUsu, IdOperacion, NumeroLinea);
        }

        public IEnumerable<LineaCompra> FindAll(int IdUsu, int IdOperacion)
        {
            using var context = new TiendaRopaContext();
            var lineasDeCompra = context.LineasCompra.ToList();
            return from lc in lineasDeCompra
                   where lc.IdUsu == IdUsu && lc.IdOperacion == IdOperacion
                   select lc;
        }
    }
}