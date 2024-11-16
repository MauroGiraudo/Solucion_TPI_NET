using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Forms.Model.Prendas;
using Newtonsoft.Json;
using Windows_Forms.Shared;

namespace Windows_Forms.Negocio
{
    public class MarcaNegocio
    {
        static readonly string defaultURL = "http://localhost:5108/api/Marca/";

        public async static Task<Marca> GetOne(int IdMarca)
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL);
            var marcas = JsonConvert.DeserializeObject<List<Marca>>(response);
            var resultado =
                   from m in marcas
                   where m.IdMarca == IdMarca
                   select m;
            return resultado.First();
        }

        public async static Task<IEnumerable<Marca>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL);
            var data = JsonConvert.DeserializeObject<List<Marca>>(response);
            return data;
        }

        public async static Task<Boolean> Add(Marca marca)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL, marca);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                try
                {
                    return JsonConvert.DeserializeObject<Boolean>(await response.Content.ReadAsStringAsync());

                } catch(Exception exc)
                {
                    var data = JsonConvert.DeserializeObject<string>(await response.Content.ReadAsStringAsync());
                    Errors.Errores.Add(data);
                    return false;
                }
            }
        }

        public async static Task<Boolean> Update(Marca marca)
        {
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync(defaultURL + marca.IdMarca, marca);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Boolean> Delete(Marca marca)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync(defaultURL + marca.IdMarca);
            return response.IsSuccessStatusCode;
        }
    }
}
