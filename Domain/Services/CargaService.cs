using Domain.Model.Cargas;

namespace Domain.Services
{
    public class CargaService
    {
        public  void Add(Carga carga)
        {
            using var context = new TiendaRopaContext();

            context.Cargas.Add(carga);
            context.SaveChanges();
        }

        public  void Update(Carga carga)
        {
            using var context = new TiendaRopaContext();

            Carga? cargaToUpdate = context.Cargas.Find(carga.IdOperacion);

            if (cargaToUpdate != null)
            {
                cargaToUpdate.FecOperacion = carga.FecOperacion;
                cargaToUpdate.EstadoOperacion = carga.EstadoOperacion;
                cargaToUpdate.Empleado = carga.Empleado;
                context.SaveChanges();
            }
        }

        public  void Delete(Carga carga)
        {
            using var context = new TiendaRopaContext();

            context.Cargas.Remove(carga);
            context.SaveChanges();
            
        }

        public  Carga? GetOne(int IdOperacion)
        {
            using var context = new TiendaRopaContext();
            return context.Cargas.Find(IdOperacion);
        }

        public  IEnumerable<Carga> FindAll()
        {
            using var context = new TiendaRopaContext();
            return context.Cargas.ToList();
        }
    }
}