using Domain.Model.Shared;
using Domain.Model.Usuarios;
using ProgramaPrincipal;

namespace Domain.Services
{
    public class UsuarioService
    {
        public void Add(Usuario usuario)
        {
            using var context = new TiendaRopaContext();
            if (usuario.TipoUsuario == "Cliente")
            {
                 Cliente nuevoUsuario = new Cliente();
            }
            else
            {
                Empleado nuevoUsuario = new Empleado();
            }
            nuevoUsuario.IdUsu = usuario.IdUsu;
            nuevoUsuario.Nombre = usuario.Nombre;
            nuevoUsuario.Apellido = usuario.Apellido;
            nuevoUsuario.Email = usuario.Email;
            nuevoUsuario.Telefono = usuario.Telefono;
            nuevoUsuario.FecNacimiento = usuario.FecNacimiento;
            nuevoUsuario.UserName = usuario.UserName;
            nuevoUsuario.Contraseña = usuario.Contraseña;
            nuevoUsuario.TipoUsuario = usuario.TipoUsuario;

            context.Clientes.Add(cliente);
            context.SaveChanges();
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }
    }
}