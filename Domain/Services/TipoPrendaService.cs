using Domain.Model.Prendas;
using ProgramaPrincipal;

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

        public void Delete(int idTipoPrenda)
        {
            using var context = new TiendaRopaContext();

            TipoPrenda? tipoPrendaToDelete = context.TiposPrenda.Find(idTipoPrenda);

            if (tipoPrendaToDelete != null)
            {
                context.TiposPrenda.Remove(tipoPrendaToDelete);
                context.SaveChanges();
            }
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