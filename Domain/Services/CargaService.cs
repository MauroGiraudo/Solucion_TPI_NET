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

        /*public  void Update(Carga carga)
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
        }*/

        public void Update(Carga carga)
        {
            using var context = new TiendaRopaContext();
            context.Entry(carga).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public  void Delete(Carga carga)
        {
            using var context = new TiendaRopaContext();

            context.Cargas.Remove(carga);
            context.SaveChanges();
            
        }

        public  Carga? GetOne(int IdUsu, int IdOperacion)
        {
            using var context = new TiendaRopaContext();
            return context.Cargas.Find(IdUsu, IdOperacion);
        }

        public  IEnumerable<Carga> FindAll(int IdUsu)
        {
            using var context = new TiendaRopaContext();
            var cargas = context.Cargas.ToList();
            return from c in cargas
                   where c.IdUsu == IdUsu
                   select c;
        }
    }
}