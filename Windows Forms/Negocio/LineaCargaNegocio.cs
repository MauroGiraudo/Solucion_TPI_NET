using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Forms.Model.Cargas;
using Windows_Forms.Model.Prendas;
using Newtonsoft.Json;
using Windows_Forms.Shared;

namespace Windows_Forms.Negocio
{
    public class LineaCargaNegocio
    {
        //static readonly string defaultURL = "http://localhost:5108/api/Usuario/" + Convert.ToString(UsuarioNegocio.Usuario?.IdUsu) + "/Carga/" + Convert.ToString(CargaNegocio.MiCarga?.IdOperacion) + "/LineaCarga/";
    
        private static string GetURL(int IdUsu, int IdOperacion)
        {
            return "http://localhost:5108/api/Usuario/" + Convert.ToString(IdUsu) + "/Carga/" + Convert.ToString(IdOperacion) + "/LineaCarga/";
        }
        public async static Task<IEnumerable<LineaCarga>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(GetURL(UsuarioNegocio.Usuario.IdUsu, CargaNegocio.MiCarga.IdOperacion));
            return JsonConvert.DeserializeObject<List<LineaCarga>>(response);
        }

        public async static Task<IEnumerable<PrendaPedido>> SetPrendasPedido()
        {
            var lineas = await GetAll();
            List<PrendaPedido> prendasPedido = new List<PrendaPedido>();
            foreach (var linea in lineas)
            {
                var prenda = await PrendaNegocio.GetOne(linea.IdPrenda);
                var precio = await PrecioPrendaNegocio.GetCurrentPrecio(linea.IdPrenda);
                PrendaPedido prendaPedido = new PrendaPedido
                {
                    NumeroLinea = linea.NumeroLinea,
                    Prenda = prenda.Descripcion,
                    Cantidad = linea.CantidadPrenda,
                    Precio = precio.Valor * linea.CantidadPrenda
                };
                prendasPedido.Add(prendaPedido);
            }
            return prendasPedido;
        }

        //static readonly string detalleCargaURL = "http://localhost:5108/api/Usuario/" + Convert.ToString(UsuarioNegocio.Usuario?.IdUsu) + "/Carga/";
        public async static Task<IEnumerable<PrendaPedido>> SetPrendasPedido_CargaMuestra()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(GetURL(UsuarioNegocio.Usuario.IdUsu, CargaNegocio.CargaMuestra.IdOperacion));
            IEnumerable<LineaCarga>? lineas = JsonConvert.DeserializeObject<List<LineaCarga>>(response);
            List<PrendaPedido> prendasPedido = new List<PrendaPedido>();
            foreach (var linea in lineas)
            {
                var prenda = await PrendaNegocio.GetOne(linea.IdPrenda);
                var precio = await PrecioPrendaNegocio.GetCurrentPrecio(linea.IdPrenda);
                PrendaPedido prendaPedido = new PrendaPedido
                {
                    NumeroLinea = linea.NumeroLinea,
                    Prenda = prenda.Descripcion,
                    Cantidad = linea.CantidadPrenda,
                    Precio = precio.Valor * linea.CantidadPrenda
                };
                prendasPedido.Add(prendaPedido);
            }
            return prendasPedido;
        }

        public async static Task<Boolean> Post(LineaCarga lineaCarga)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(GetURL(UsuarioNegocio.Usuario.IdUsu, CargaNegocio.MiCarga.IdOperacion), lineaCarga);
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

        public async static Task<Boolean> Delete(int NumeroLinea)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync(GetURL(UsuarioNegocio.Usuario.IdUsu, CargaNegocio.MiCarga.IdOperacion) + NumeroLinea);
            return response.IsSuccessStatusCode;
        }
    }
}
