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
    public class PrecioPrendaNegocio
    {
        static readonly string defaultURL = "http://localhost:5108/api/Prenda/";

        public async static Task<PrecioPrenda> GetCurrentPrecio(int IdPrenda)
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL + IdPrenda + "/PrecioPrenda");
            var precio = JsonConvert.DeserializeObject<PrecioPrenda>(response);
            return precio;
        }

        public async static Task<Boolean> Add(PrecioPrenda precio)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL + precio.IdPrenda + "/PrecioPrenda", precio);
            if(response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                try
                {
                    return JsonConvert.DeserializeObject<Boolean>(await response.Content.ReadAsStringAsync());
                }
                catch(Exception exc)
                {
                    var data = JsonConvert.DeserializeObject<string>(await response.Content.ReadAsStringAsync());
                    Errors.Errores.Add(data);
                    return false;
                }
            }
        }
    }
}
