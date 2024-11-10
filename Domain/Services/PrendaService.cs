using Domain.Model.Prendas;

namespace Domain.Services
{
    public class PrendaService
    {
        public void Add(Prenda prenda)
        {
            using var context = new TiendaRopaContext();

            context.Prendas.Add(prenda);
            context.SaveChanges();
        }

        public void Delete(Prenda prenda)
        {
            using var context = new TiendaRopaContext();

            context.Prendas.Remove(prenda);
            context.SaveChanges();
        }

        /*public void Update(Prenda prenda)
        {
            using var context = new TiendaRopaContext();

            Prenda? prendaToUpdate = context.Prendas.Find(prenda.IdPrenda);
            if (prendaToUpdate != null)
            {
                prendaToUpdate.Stock = prenda.Stock;
                prendaToUpdate.PuntoPedido = prenda.PuntoPedido;
                prendaToUpdate.Descripcion = prenda.Descripcion;
                prendaToUpdate.Talla = prenda.Talla;
                prendaToUpdate.Modelo = prenda.Modelo;
                prendaToUpdate.TipoDePrenda = prenda.TipoDePrenda;
                prendaToUpdate.MarcaPrenda = prenda.MarcaPrenda;
                context.SaveChanges();
            }
        }*/

        public void Update(Prenda prenda)
        {
            using var context = new TiendaRopaContext();
            context.Entry(prenda).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public Prenda? GetOne(int idPrenda)
        {
            using var context = new TiendaRopaContext();
            return context.Prendas.Find(idPrenda);
        }

        public IEnumerable<Prenda> FindAll()
        {
            using var context = new TiendaRopaContext();
            return context.Prendas.ToList();
        }
    }
}