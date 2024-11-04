using Domain.Model.Prendas;

namespace Domain.Services
{
    public class MarcaService
    {
        public void Add(Marca marca)
        {
            using var context = new TiendaRopaContext();

            context.Marcas.Add(marca);
            context.SaveChanges();
        }

        public void Update(Marca marca)
        {
            using var context = new TiendaRopaContext();

            Marca? marcaToUpdate = context.Marcas.Find(marca.IdMarca);

            if (marcaToUpdate != null)
            {
                marcaToUpdate.DescripcionMarca = marca.DescripcionMarca;
                context.SaveChanges();
            }
        }

        public void Delete(Marca marca)
        {
            using var context = new TiendaRopaContext();

            context.Marcas.Remove(marca);
            context.SaveChanges();
        }

        public Marca? GetOne(int idMarca)
        {
            using var context = new TiendaRopaContext();
            return context.Marcas.Find(idMarca);
        }

        public IEnumerable<Marca> FindAll()
        {
            using var context = new TiendaRopaContext();
            return context.Marcas.ToList();
        }
    }
}