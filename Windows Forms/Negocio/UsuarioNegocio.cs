using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Forms.Model.Usuarios;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Windows_Forms.Negocio
{
    public class UsuarioNegocio
    {
        static readonly string defaultURL = "http://localhost:5108/api/Usuario/";

        private static Usuario? _usuario;
        public static Usuario? Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
            }
        }

        public async static Task<Usuario> Login(LoginData login)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL + "login", login);
            try
            {
                var data = JsonConvert.DeserializeObject<Usuario>(await response.Content.ReadAsStringAsync());
                return data;

            } catch (Exception exc)
            {
                var data = JsonConvert.DeserializeObject<string>(await response.Content.ReadAsStringAsync());
                Errors.Errores.Add(data);
                return null;
            }
            
        }

        public static void Logout()
        {
            Usuario = null;
        }

        public async static Task<Boolean> Post(Usuario usuario)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL, usuario);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Usuario>? Put(Usuario usuario)
        {
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync(defaultURL + usuario.IdUsu, usuario);
            try
            {
                var data = await response.Content.ReadAsAsync<Usuario>();
                return data;
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        public async static Task<Boolean> Delete(Usuario usuario)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync(defaultURL + usuario.IdUsu);
            return response.IsSuccessStatusCode;
        }
    }
}
