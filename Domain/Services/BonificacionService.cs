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

        public Bonificacion? GetByValue(float cantidad)
        {
            using var context = new TiendaRopaContext();
            var bonificaciones = context.Bonificaciones.ToList();
            var cantidadFiltrada =
                from b in bonificaciones
                where b.CantidadParaDescuento <= cantidad && b.FecVigenciaBonificacion <= DateTime.Now
                select b.CantidadParaDescuento;
            if(cantidadFiltrada.Count() == 0)
            {
                return null;
            }
            var cant = cantidadFiltrada.Max();
            var fechasFiltradas =
                from b in bonificaciones
                where b.FecVigenciaBonificacion <= DateTime.Now && b.CantidadParaDescuento == cant
                select b.FecVigenciaBonificacion;
            if(fechasFiltradas.Count() == 0)
            {
                return null;
            }
            var fecha = fechasFiltradas.Max();
            var bonificacion =
                from b in bonificaciones
                where b.CantidadParaDescuento == cant && b.FecVigenciaBonificacion == fecha
                select b;
            return bonificacion.FirstOrDefault();

        }
    }
}