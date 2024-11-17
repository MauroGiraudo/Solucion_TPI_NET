using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Forms.Model.Compras;
using Newtonsoft.Json;
using Windows_Forms.Model.Prendas;

namespace Windows_Forms.Negocio
{
    public class LineaCompraNegocio
    {
        //static readonly string defaultURL = "http://localhost:5108/api/Usuario/" + Convert.ToString(UsuarioNegocio.Usuario?.IdUsu) + "/Compra/" + Convert.ToString(CompraNegocio.MiCompra?.IdOperacion) + "/LineaCompra/";
    
        private static string GetURL(int IdUsu, int IdOperacion)
        {
            return "http://localhost:5108/api/Usuario/" + Convert.ToString(IdUsu) + "/Compra/" + Convert.ToString(IdOperacion) + "/LineaCompra/";
        }
        public async static Task<IEnumerable<LineaCompra>> GetAll()
        {
            //var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL));
            var response = await Conexion.Instancia.Cliente.GetStringAsync(GetURL(UsuarioNegocio.Usuario.IdUsu, CompraNegocio.MiCompra.IdOperacion));
            return JsonConvert.DeserializeObject<List<LineaCompra>>(response);
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

        //static readonly string detalleCompraURL = "http://localhost:5108/api/Usuario/" + Convert.ToString(UsuarioNegocio.Usuario?.IdUsu) + "/Compra/";
        public async static Task<IEnumerable<PrendaPedido>> SetPrendasPedido_CompraMuestra()
        {
            //var response = await Conexion.Instancia.Cliente.GetStringAsync(detalleCompraURL + Convert.ToString(CompraNegocio.CompraMuestra?.IdOperacion) + "/LineaCompra/");
            var response = await Conexion.Instancia.Cliente.GetStringAsync(GetURL(UsuarioNegocio.Usuario.IdUsu, CompraNegocio.CompraMuestra.IdOperacion));
            IEnumerable<LineaCompra>? lineas = JsonConvert.DeserializeObject<List<LineaCompra>>(response);
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

        public async static Task<Boolean> Post(LineaCompra lineaCompra)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(GetURL(UsuarioNegocio.Usuario.IdUsu, CompraNegocio.MiCompra.IdOperacion), lineaCompra);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Boolean> Delete(int NumeroLinea)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync(GetURL(UsuarioNegocio.Usuario.IdUsu, CompraNegocio.MiCompra.IdOperacion) + NumeroLinea);
            return response.IsSuccessStatusCode;
        }
    }
}
