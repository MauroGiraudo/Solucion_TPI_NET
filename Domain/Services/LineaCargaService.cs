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

        /*public void Update(LineaCarga lineaCarga)
        {
            using var context = new TiendaRopaContext();

            LineaCarga? lineaCargaToUpdate = context.LineasCarga.Find(lineaCarga.NumeroLinea, lineaCarga.IdOperacion, lineaCarga.IdUsu);

            if (lineaCargaToUpdate != null)
            {
                lineaCargaToUpdate.CantidadPrenda = lineaCarga.CantidadPrenda;
                context.SaveChanges();
            }
        }*/

        public void Update(LineaCarga lineaCarga)
        {
            using var context = new TiendaRopaContext();
            context.Entry(lineaCarga).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(LineaCarga lineaCarga)
        {
            using var context = new TiendaRopaContext();

            context.LineasCarga.Remove(lineaCarga);
            context.SaveChanges();
        }

        public LineaCarga? GetOne(int IdUsu, int IdOperacion, int NumeroLinea)
        {
            using var context = new TiendaRopaContext();
            return context.LineasCarga.Find(IdUsu, IdOperacion, NumeroLinea);
        }

        public IEnumerable<LineaCarga> FindAll(int IdUsu, int IdOperacion)
        {
            using var context = new TiendaRopaContext();
            var lineasDeCarga = context.LineasCarga.ToList();
            return from lc in lineasDeCarga
                   where lc.IdUsu == IdUsu && lc.IdOperacion == IdOperacion
                   select lc;
        }
    }
}