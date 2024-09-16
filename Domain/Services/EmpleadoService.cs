using Domain.Model.Usuarios;

namespace Domain.Services
{
    public class EmpleadoService
    {
        public void Add(Empleado empleado)
        {
            using var context = new TiendaRopaContext();
            context.Empleados.Add(empleado);
            context.SaveChanges();
        }

        public void Update(Empleado empleado)
        {
            using var context = new TiendaRopaContext();

            Empleado? empleadoToUpdate = context.Empleados.Find(empleado.IdUsu);

            if (empleadoToUpdate != null)
            {
                empleadoToUpdate.Nombre = empleado.Nombre;
                empleadoToUpdate.Apellido = empleado.Apellido;
                empleadoToUpdate.Email = empleado.Email;
                empleadoToUpdate.Telefono = empleado.Telefono;
                empleadoToUpdate.FecNacimiento = empleado.FecNacimiento;
                empleadoToUpdate.UserName = empleado.UserName;
                empleadoToUpdate.Contrasenia = empleado.Contrasenia;
                context.SaveChanges();
            }
        }

        public void Delete(int IdUsu)
        {
            using var context = new TiendaRopaContext();

            Empleado? cargaToDelete = context.Empleados.Find(IdUsu);

            if (cargaToDelete != null)
            {
                context.Empleados.Remove(cargaToDelete);
                context.SaveChanges();
            }
        }

        public Empleado? GetOne(int IdUsu)
        {
            using var context = new TiendaRopaContext();
            return context.Empleados.Find(IdUsu);
        }

        public IEnumerable<Empleado> FindAll()
        {
            using var context = new TiendaRopaContext();
            return context.Empleados.ToList();
        }
    }
}