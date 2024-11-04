using Domain.Model.Prendas;

namespace Domain.Services
{
    public class TipoPrendaService
    {
        public void Add(TipoPrenda tipoPrenda)
        {
            using var context = new TiendaRopaContext();

            context.TiposPrenda.Add(tipoPrenda);
            context.SaveChanges();
        }

        public void Update(TipoPrenda tipoPrenda)
        {
            using var context = new TiendaRopaContext();

            TipoPrenda? tipoPrendaToUpdate = context.TiposPrenda.Find(tipoPrenda.IdTipoPrenda);

            if (tipoPrendaToUpdate != null)
            {
                tipoPrendaToUpdate.DescripcionTipoPrenda = tipoPrenda.DescripcionTipoPrenda;
                context.SaveChanges();
            }
        }

        public void Delete(TipoPrenda tipoPrenda)
        {
            using var context = new TiendaRopaContext();

            context.TiposPrenda.Remove(tipoPrenda);
            context.SaveChanges();
        }

        public TipoPrenda? GetOne(int idTipoPrenda)
        {
            using var context = new TiendaRopaContext();
            return context.TiposPrenda.Find(idTipoPrenda);
        }

        public IEnumerable<TipoPrenda> FindAll()
        {
            using var context = new TiendaRopaContext();
            return context.TiposPrenda.ToList();
        }
    }
}