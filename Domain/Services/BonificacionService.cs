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

        public bool Delete(int IdBonificacion)
        {
            using var context = new TiendaRopaContext();

            Bonificacion? bonificacionToDelete = context.Bonificaciones.Find(IdBonificacion);

            if (bonificacionToDelete == null)
            {
                return false;
            }
            context.Bonificaciones.Remove(bonificacionToDelete);
            context.SaveChanges();
            return true;
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