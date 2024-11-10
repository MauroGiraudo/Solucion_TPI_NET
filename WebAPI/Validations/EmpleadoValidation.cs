using Domain.Services;
using Domain.Model.Usuarios;

namespace WebAPI.Validations
{
    public class EmpleadoValidation
    {
        public static string? Parse(EmpleadoService service, Empleado empleado)
        {
            var empleados = service.FindAll();
            foreach(Empleado e in empleados)
            {
                if(empleado.IdUsu != e.IdUsu && empleado.Email == e.Email)
                {
                    return "El E-mail ingresado ya se encuentra en uso";
                }
                if(empleado.IdUsu != e.IdUsu && empleado.UserName == e.UserName)
                {
                    return "El nombre de usuario ya se encuentra en uso";
                }
                if (empleado.Nombre.Length > 50)
                {
                    return "El nombre no debe contener más de 50 caracteres";
                }
                if (empleado.Apellido.Length > 50)
                {
                    return "El apellido no debe contener más de 50 caracteres";
                }
                if(empleado.UserName.Length > 50)
                {
                    return "El nombre de usuario no debe contener más de 50 caracteres";
                }
                if(empleado.Contrasenia.Length > 50)
                {
                    return "La contraseña no debe contener más ded 50 caracteres";
                }
            }
            return null;
        }
    }
}