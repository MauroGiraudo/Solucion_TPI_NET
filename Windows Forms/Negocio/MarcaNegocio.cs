using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Forms.Model.Prendas;
using Newtonsoft.Json;

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
    }
}
