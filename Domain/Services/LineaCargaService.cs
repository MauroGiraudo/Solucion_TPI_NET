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

        public void Update(LineaCarga lineaCarga)
        {
            using var context = new TiendaRopaContext();

            LineaCarga? lineaCargaToUpdate = context.LineasCarga.Find(lineaCarga.NumeroLinea, lineaCarga.Carga.IdOperacion);

            if (lineaCargaToUpdate != null)
            {
                lineaCargaToUpdate.CantidadPrenda = lineaCarga.CantidadPrenda;
                lineaCargaToUpdate.Prenda = lineaCarga.Prenda;
                lineaCargaToUpdate.Carga = lineaCarga.Carga;
                context.SaveChanges();
            }
        }

        public void Delete(LineaCarga lineaCarga)
        {
            using var context = new TiendaRopaContext();

            context.LineasCarga.Remove(lineaCarga);
            context.SaveChanges();
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