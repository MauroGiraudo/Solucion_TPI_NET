using Domain.Model.Compras;

namespace Domain.Services
{
    public class BonificacionService
    {
        public void Add(Bonificacion bonificacion)
        {
            using var context = new TiendaRopaContext();

            context.Bonificaciones.Add(bonificacion);
            context.SaveChanges();
        }

        public void Update(Bonificacion bonificacion)
        {
            using var context = new TiendaRopaContext();

            Bonificacion? bonificacionToUpdate = context.Bonificaciones.Find(bonificacion.IdBonificacion);

            if (bonificacionToUpdate != null)
            {
                bonificacionToUpdate.CantidadParaDescuento = bonificacion.CantidadParaDescuento;
                bonificacionToUpdate.ProporcionDescuento = bonificacion.ProporcionDescuento;
                bonificacionToUpdate.FecVigenciaBonificacion = bonificacion.FecVigenciaBonificacion;
                context.SaveChanges();
            }
        }

        public void Delete(Bonificacion bonificacion)
        {
            using var context = new TiendaRopaContext();

            context.Bonificaciones.Remove(bonificacion);
            context.SaveChanges();
        }

        public Bonificacion? GetOne(int IdBonificacion)
        {
            using var context = new TiendaRopaContext();
            return context.Bonificaciones.Find(IdBonificacion);
        }

        public IEnumerable<Bonificacion> FindAll()
        {
            using var context = new TiendaRopaContext();
            return context.Bonificaciones.ToList();
        }
    }
}