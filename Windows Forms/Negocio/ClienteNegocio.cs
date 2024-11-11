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
    public class ClienteNegocio
    {
        static readonly string defaultURL = "http://localhost:5108/api/Cliente/";

        private static Cliente? _cliente;
        public static Cliente? Cliente
        {
            get
            {
                return _cliente;
            }
            set
            {
                _cliente = value;
            }
        }

        public async static Task<IEnumerable<Cliente>> Login(LoginData login)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL + "login", login);
            var data =  JsonConvert.DeserializeObject<List<Cliente>>(await response.Content.ReadAsStringAsync());
            return data;
        }

        public static void Logout()
        {
            Cliente = null;
            form_InicioSesion login = new form_InicioSesion();
            login.ShowDialog();
        }

        public async static Task<Boolean> Post(Cliente cliente)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL, cliente);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Cliente>? Put(Cliente cliente)
        {
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync(defaultURL + cliente.IdUsu, cliente);
            try
            {
                var data = await response.Content.ReadAsAsync<Cliente>();
                return data;
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        public async static Task<Boolean> Delete(Cliente cliente)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync(defaultURL + cliente.IdUsu);
            return response.IsSuccessStatusCode;
        }
    }
}
