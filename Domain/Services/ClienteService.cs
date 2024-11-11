using Domain.Model.Usuarios;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services {
    public class ClienteService
    {
        public void Add(Cliente cliente)
        {
            using var context = new TiendaRopaContext();

            context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        /*public void Update(Cliente cliente)
        {
            using var context = new TiendaRopaContext();

            Cliente? clienteToUpdate = context.Clientes.Find(cliente.IdUsu);

            if (clienteToUpdate != null)
            {
                clienteToUpdate.Nombre = cliente.Nombre;
                clienteToUpdate.Apellido = cliente.Apellido;
                clienteToUpdate.Email = cliente.Email;
                clienteToUpdate.Telefono = cliente.Telefono;
                clienteToUpdate.FecNacimiento = cliente.FecNacimiento;
                clienteToUpdate.UserName = cliente.UserName;
                clienteToUpdate.Contrasenia = cliente.Contrasenia;
                context.SaveChanges();
            }
        }*/

        public void Update(Cliente cliente)
        {
            using var context = new TiendaRopaContext();

            context.Entry(cliente).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(Cliente cliente)
        {
            using var context = new TiendaRopaContext();

            context.Clientes.Remove(cliente);
            context.SaveChanges();
        }

        public Cliente? GetOne(int IdUsu)
        {
            using var context = new TiendaRopaContext();

            return context.Clientes.Find(IdUsu);
        }

        public IEnumerable<Cliente> GetOneByUser(string user)
        {
            using var context = new TiendaRopaContext();
            var clientes = context.Clientes.ToList();
            return from c in clientes
                   where c.UserName == user
                   select c;
        }

        public IEnumerable<Cliente> FindAll()
        {
            using var context = new TiendaRopaContext();
            return context.Clientes.ToList();
        }
    }
}