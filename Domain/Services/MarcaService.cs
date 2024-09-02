﻿using Domain.Model.Prendas;
using ProgramaPrincipal;

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

        public void Delete(int idMarca)
        {
            using var context = new TiendaRopaContext();

            Marca? marcaToDelete = context.Marcas.Find(idMarca);

            if (marcaToDelete != null)
            {
                context.Marcas.Remove(marcaToDelete);
                context.SaveChanges();
            }
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