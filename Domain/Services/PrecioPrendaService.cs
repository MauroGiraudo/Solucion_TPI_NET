using Domain.Model.Prendas;

namespace Domain.Services
{
    public class PrecioPrendaService
    {
        public void Add(PrecioPrenda precioPrenda)
        {
            using var context = new TiendaRopaContext();

            context.PreciosPrenda.Add(precioPrenda);
            context.SaveChanges();
        }

        public void Update(PrecioPrenda precioPrenda)
        {
            using var context = new TiendaRopaContext();
            PrecioPrenda? precioPrendaToUpdate = context.PreciosPrenda.Find(precioPrenda.Prenda.IdPrenda, precioPrenda.FecVigencia);
            if (precioPrendaToUpdate != null)
            {
                precioPrendaToUpdate.Valor = precioPrenda.Valor;
                context.SaveChanges();
            }
        }

        public void Delete(PrecioPrenda precioPrenda)
        {
            using var context = new TiendaRopaContext();

            context.PreciosPrenda.Remove(precioPrenda);
            context.SaveChanges();
        }

        public PrecioPrenda? GetOne(int idPrenda, DateTime fecVigencia)
        {
            using var context = new TiendaRopaContext();
            return context.PreciosPrenda.Find(idPrenda, fecVigencia);
        }

        public IEnumerable<PrecioPrenda> FindAll()
        {
            using var context = new TiendaRopaContext();
            return context.PreciosPrenda.ToList();
        }
    }
}