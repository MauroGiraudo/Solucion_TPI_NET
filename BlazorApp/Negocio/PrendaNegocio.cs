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

        public async static Task<Prenda> GetOneByDescAndTalla(string descripcion, string talla)
        {
            var prendas = await GetAll();
            var filtrado =
                from p in prendas
                where p.Descripcion == descripcion && p.Talla == talla
                select p;
            return filtrado.First();
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
                    TipoDePrenda = tipoPrenda.DescripcionTipoPrenda,
                    Marca = marca.DescripcionMarca,
                    Precio = precio.Valor,
                    Stock = prenda.Stock
                };
                prendasMuestra.Add(prendaMuestra);
            }
            return prendasMuestra;
        }

        public async static Task<Boolean> Add(Prenda prenda)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL, prenda);
            if (response.IsSuccessStatusCode)
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

        public async static Task<Boolean> Update(Prenda prenda)
        {
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync(defaultURL + prenda.IdPrenda, prenda);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
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
        }

        public async static Task<Boolean> Delete(Prenda prenda)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync(defaultURL + prenda.IdPrenda);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
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
        }
    }
}
