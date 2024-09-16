using Domain.Model.Cargas;

namespace Domain.Services
{
    public class LineaCargaService
    {
        public void Add(LineaCarga lineaCarga)
        {
            using var context = new TiendaRopaContext();

            context.LineasCarga.Add(lineaCarga);
            context.SaveChanges();
        }

        public void Update(LineaCarga lineaCarga, int IdOperacion)
        {
            using var context = new TiendaRopaContext();

            LineaCarga? lineaCargaToUpdate = context.LineasCarga.Find(lineaCarga.NumeroLinea, IdOperacion);

            if (lineaCargaToUpdate != null)
            {
                lineaCargaToUpdate.CantidadPrenda = lineaCarga.CantidadPrenda;
                lineaCargaToUpdate.Prenda = lineaCarga.Prenda;
                lineaCargaToUpdate.Carga = lineaCarga.Carga;
                context.SaveChanges();
            }
        }

        public void Delete(int NumeroLinea, int IdOperacion)
        {
            using var context = new TiendaRopaContext();

            LineaCarga? lineaCargaToDelete = context.LineasCarga.Find(NumeroLinea, IdOperacion);

            if (lineaCargaToDelete != null)
            {
                context.LineasCarga.Remove(lineaCargaToDelete);
                context.SaveChanges();
            }
        }

        public LineaCarga? GetOne(int NumeroLinea, int IdOperacion)
        {
            using var context = new TiendaRopaContext();
            return context.LineasCarga.Find(NumeroLinea, IdOperacion);
        }

        public IEnumerable<LineaCarga> FindAll()
        {
            using var context = new TiendaRopaContext();
            return context.LineasCarga.ToList();
        }
    }
}