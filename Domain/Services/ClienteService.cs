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

        public void Update(Cliente cliente)
        {
            using var context = new TiendaRopaContext();

            Cliente? clienteToUpdate = context.Clientes.Find(cliente.IdUsu);

            if (clienteToUpdate != null)
            {
                context.Entry(clienteToUpdate).State = EntityState.Modified;
                clienteToUpdate.Nombre = cliente.Nombre;
                clienteToUpdate.Apellido = cliente.Apellido;
                clienteToUpdate.Email = cliente.Email;
                clienteToUpdate.Telefono = cliente.Telefono;
                clienteToUpdate.FecNacimiento = cliente.FecNacimiento;
                clienteToUpdate.UserName = cliente.UserName;
                clienteToUpdate.Contrasenia = cliente.Contrasenia;
                context.SaveChanges();
            }
        }

        public bool Delete(int IdUsu)
        {
            using var context = new TiendaRopaContext();

            Cliente? cargaToDelete = context.Clientes.Find(IdUsu);

            if (cargaToDelete == null)
            {
                return false;
            }
            context.Clientes.Remove(cargaToDelete);
            context.SaveChanges();
            return true;
        }

        public Cliente? GetOne(int IdUsu)
        {
            using var context = new TiendaRopaContext();
            return context.Clientes.Find(IdUsu);
        }

        public IEnumerable<Cliente> FindAll()
        {
            using var context = new TiendaRopaContext();
            return context.Clientes.ToList();
        }
    }
}