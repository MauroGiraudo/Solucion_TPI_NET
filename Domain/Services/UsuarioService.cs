using Domain.Model.Usuarios;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services {
    public class UsuarioService
    {
        public void Add(Usuario usuario)
        {
            using var context = new TiendaRopaContext();

            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }

        /*public void Update(Usuario usuario)
        {
            using var context = new TiendaRopaContext();

            Usuario? usuarioToUpdate = context.Usuarios.Find(usuario.IdUsu);

            if (usuarioToUpdate != null)
            {
                usuarioToUpdate.Nombre = usuario.Nombre;
                usuarioToUpdate.Apellido = usuario.Apellido;
                usuarioToUpdate.Email = usuario.Email;
                usuarioToUpdate.Telefono = usuario.Telefono;
                usuarioToUpdate.FecNacimiento = usuario.FecNacimiento;
                usuarioToUpdate.UserName = usuario.UserName;
                usuarioToUpdate.Contrasenia = usuario.Contrasenia;
                context.SaveChanges();
            }
        }*/

        public void Update(Usuario usuario)
        {
            using var context = new TiendaRopaContext();

            context.Entry(usuario).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(Usuario usuario)
        {
            using var context = new TiendaRopaContext();

            context.Usuarios.Remove(usuario);
            context.SaveChanges();
        }

        public Usuario? GetOne(int IdUsu)
        {
            using var context = new TiendaRopaContext();

            return context.Usuarios.Find(IdUsu);
        }

        public Usuario? GetOneByUser(string user)
        {
            using var context = new TiendaRopaContext();
            var usuarios = context.Usuarios.ToList();
            var result = 
                from c in usuarios
                where c.UserName == user
                select c;
            return result.FirstOrDefault();
        }

        public IEnumerable<Usuario> FindAll()
        {
            using var context = new TiendaRopaContext();
            return context.Usuarios.ToList();
        }
    }
}