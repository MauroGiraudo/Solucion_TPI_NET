using Domain.Model.Cargas;
using Domain.Model.Compras;
using ProgramaPrincipal;

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

        public  void Delete(int IdOperacion)
        {
            using var context = new TiendaRopaContext();

            Carga? cargaToDelete = context.Cargas.Find(IdOperacion);

            if (cargaToDelete != null)
            {
                context.Cargas.Remove(cargaToDelete);
                context.SaveChanges();
            }
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