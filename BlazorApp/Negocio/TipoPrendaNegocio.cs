using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorApp.Model.Prendas;
using Newtonsoft.Json;
using BlazorApp.Shared;

namespace BlazorApp.Negocio
{
    public class TipoPrendaNegocio
    {
        static readonly string defaultURL = "http://localhost:5108/api/TipoPrenda/";

        public async static Task<TipoPrenda> GetOne(int IdTipoPrenda)
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL);
            var tiposDePrenda = JsonConvert.DeserializeObject<List<TipoPrenda>>(response);
            var resultado =
                   from tp in tiposDePrenda
                   where tp.IdTipoPrenda == IdTipoPrenda
                   select tp;
            return resultado.First();
        }

        public async static Task<IEnumerable<TipoPrenda>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL);
            var data = JsonConvert.DeserializeObject<List<TipoPrenda>>(response);
            return data;
        }

        public async static Task<Boolean> Add(TipoPrenda tipoPrenda)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL, tipoPrenda);
            if(response.IsSuccessStatusCode)
            {
                return true;
            }
            try
            {
                return JsonConvert.DeserializeObject<Boolean>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception exc)
            {
                var data = JsonConvert.DeserializeObject<string>(await response.Content.ReadAsStringAsync());
                Errors.Errores.Add(data);
                return false;
            }
            

        }

        public async static Task<Boolean> Update(TipoPrenda tipoPrenda)
        {
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync(defaultURL + tipoPrenda.IdTipoPrenda, tipoPrenda);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Boolean> Delete(TipoPrenda tipoPrenda)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync(defaultURL + tipoPrenda.IdTipoPrenda);
            return response.IsSuccessStatusCode;
        }
    }
}
