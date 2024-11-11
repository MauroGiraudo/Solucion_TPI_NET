using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Forms.Model.Prendas;
using Newtonsoft.Json;

namespace Windows_Forms.Negocio
{
    public class PrendaNegocio
    {
        static readonly string defaultURL = "http://localhost:5108/api/Prenda/";

        public async static Task<IEnumerable<Prenda>> GetAll()
        {

           var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL);
           return JsonConvert.DeserializeObject<List<Prenda>>(response);
        }

        public async static Task<Prenda> GetOne(int IdPrenda)
        {
            var data = await GetAll();
            var result = from p in data
                         where p.IdPrenda == IdPrenda
                         select p;
            return result.First();
        }

        public async static Task<IEnumerable<PrendaMuestra>> SetPrendasMuestra()
        {
            var prendas = await GetAll();
            List<PrendaMuestra> prendasMuestra = new List<PrendaMuestra>();
            foreach (var prenda in prendas)
            {
                var tipoPrenda = await TipoPrendaNegocio.GetOne(prenda.IdTipoPrenda);
                var marca = await MarcaNegocio.GetOne(prenda.IdMarca);
                var precio = await PrecioPrendaNegocio.GetCurrentPrecio(prenda.IdPrenda);
                PrendaMuestra prendaMuestra = new PrendaMuestra
                {
                    IdPrenda = prenda.IdPrenda,
                    Descripcion = prenda.Descripcion,
                    Talla = prenda.Talla,
                    Modelo = prenda.Modelo,
                    TipoDePrenda = tipoPrenda.DescripcionTipoPrenda,
                    Marca = marca.DescripcionMarca,
                    Precio = precio.Valor,
                    Stock = prenda.Stock
                };
                prendasMuestra.Add(prendaMuestra);
            }
            return prendasMuestra;
        }
    }
}
