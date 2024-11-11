using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Forms.Model.Prendas;
using Newtonsoft.Json;

namespace Windows_Forms.Negocio
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
    }
}
