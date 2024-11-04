using Domain.Services;
using Domain.Model.Usuarios;

namespace WebAPI.Validations
{
    public class ClienteValidation
    {
        public static string? Parse(ClienteService service, Cliente cliente)
        {
            var clientes = service.FindAll();
            foreach(Cliente c in clientes)
            {
                if(cliente.Email == c.Email)
                {
                    return "El E-mail ingresado ya se encuentra en uso";
                }
                if(cliente.UserName == c.UserName)
                {
                    return "El nombre de usuario ya se encuentra en uso";
                }
                if (cliente.Nombre.Length > 50)
                {
                    return "El nombre no debe contener más de 50 caracteres";
                }
                if (cliente.Apellido.Length > 50)
                {
                    return "El apellido no debe contener más de 50 caracteres";
                }
                if(cliente.UserName.Length > 50)
                {
                    return "El nombre de usuario no debe contener más de 50 caracteres";
                }
                if(cliente.Contrasenia.Length > 50)
                {
                    return "La contraseña no debe contener más ded 50 caracteres";
                }
            }
            return null;
        }
    }
}