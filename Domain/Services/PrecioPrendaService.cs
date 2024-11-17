using Domain.Model.Prendas;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.ComponentModel.DataAnnotations;

namespace Domain.Services
{
    public class PrecioPrendaService
    {
        public void Add(PrecioPrenda precioPrenda)
        {
            using var context = new TiendaRopaContext();

            context.PreciosPrenda.Add(precioPrenda);
            context.SaveChanges();
        }

        public void Update(PrecioPrenda precioPrenda)
        {
            using var context = new TiendaRopaContext();
            PrecioPrenda? precioPrendaToUpdate = context.PreciosPrenda.Find(precioPrenda.IdPrenda, precioPrenda.FecVigencia);
            if (precioPrendaToUpdate != null)
            {
                precioPrendaToUpdate.Valor = precioPrenda.Valor;
                context.SaveChanges();
            }
        }

        public void Delete(PrecioPrenda precioPrenda)
        {
            using var context = new TiendaRopaContext();

            context.PreciosPrenda.Remove(precioPrenda);
            context.SaveChanges();
        }

        public IEnumerable<PrecioPrenda> FindAll(int IdPrenda)
        {
            using var context = new TiendaRopaContext();
            var precios = context.PreciosPrenda.ToList();
            return from p in precios
                   where p.IdPrenda == IdPrenda
                   select p;
        }

        public PrecioPrenda? GetOne(int IdPrenda, DateTime fecVigencia)
        {
            using var context = new TiendaRopaContext();
            return context.PreciosPrenda.Find(IdPrenda, fecVigencia);
        }

        //LA IDEA ES QUE DEVUELVA LA MAYOR FECHA, LA CUAL SE UTILIZARÁ PARA OBTENER EL PRECIO ACTUAL
        public DateTime? GetDate(int IdPrenda, DateTime fecha)
        {
            using var context = new TiendaRopaContext();

            List<PrecioPrenda> precios = context.PreciosPrenda.ToList();
            IEnumerable<DateTime?> preciosFiltrados =  
                from p in precios
                where p.FecVigencia <= fecha && p.IdPrenda == IdPrenda
                select p.FecVigencia;
            if (!preciosFiltrados.Any())
            {
                return null;
            }
            return preciosFiltrados.Max();
        }
    }
}