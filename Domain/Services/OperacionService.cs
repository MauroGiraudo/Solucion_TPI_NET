using Domain.Model.Compras;
using ProgramaPrincipal;

namespace Domain.Services
{
    public class OperacionService
    {
        public void Add(Operacion operacion)
        {
            using var context = new TiendaRopaContext();

            context.Operaciones.Add(operacion);
            context.SaveChanges();
        }

        public void Update(Operacion operacion)
        {
            using var context = new TiendaRopaContext();

            Operacion? operacionToUpdate = context.Operaciones.Find(operacion.IdOperacion);

            if (operacionToUpdate != null)
            {
                operacionToUpdate.DateTime = operacion.DateTime;
                operacionToUpdate.EstadoOperacion = operacion.EstadoOperacion;
                context.SaveChanges();
            }
        }

        public void Delete(int idOperacion)
        {
            using var context = new TiendaRopaContext();

            Operacion? operacionToDelete = context.Operaciones.Find(operacion.IdOperacion);

            if (operacionToDelete != null)
            {
                context.Operaciones.Remove(operacionToDelete);
                context.SaveChanges();
            }
        }

        public Operacion? GetOne(int idOperacion)
        {
            using var context = new TiendaRopaContext();
            return context.Operaciones.Find(IdOperacion);
        }

        public IEnumerable<Operacion> FindAll()
        {
            using var context = new TiendaRopaContext();
            return context.Operaciones.ToList();
        }
    }
}