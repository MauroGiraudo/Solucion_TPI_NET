using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Forms.Model.Prendas;
using Newtonsoft.Json;

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
    }
}
