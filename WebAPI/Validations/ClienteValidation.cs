using Domain.Services;
using Domain.Model.Usuarios;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Validations
{
    public class ClienteValidation
    {
        public static string? Parse(ClienteService service, Cliente cliente)
        {
            var clientes = service.FindAll();
            foreach(Cliente c in clientes)
            {
                if(cliente.IdUsu != c.IdUsu && cliente.Email == c.Email)
                {
                    return "El E-mail ingresado ya se encuentra en uso";
                }
                if(!IsValidEmail(cliente.Email))
                {
                    return "El E-mail ingresado no es válido";
                }
                if(cliente.IdUsu != c.IdUsu && cliente.UserName == c.UserName)
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
                    return "La contraseña no debe contener más de 50 caracteres";
                }
            }
            return null;
        }

        public static bool IsValidEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email))
                return false;

            var emailAttribute = new EmailAddressAttribute();
            return emailAttribute.IsValid(email);
        }

        public static bool IsValidUserName(string username)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length > 50)
            {
                return false;
            }
            return true;
        }

        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length > 50)
            {
                return false;
            }
            return true;
        }
    }
}