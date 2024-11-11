using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Forms.Model.Compras;
using Newtonsoft.Json;

namespace Windows_Forms.Negocio
{
    public class CompraNegocio
    {
        private static Compra? _micompra = null;

        private static IEnumerable<Compra> Cargar_Compra()
        {
            var result = GetEnProceso();
            return result.Result;
        }
        public static Compra? MiCompra
        {
            get
            {
                if (_micompra == null)
                { 
                    var result = GetEnProceso();
                    Task<IEnumerable<Compra>> task = new Task<IEnumerable<Compra>>(Cargar_Compra);
                    task.Start();
                    var compraResult = task.Result;
                    _micompra = compraResult.FirstOrDefault();
                }
                return _micompra;
            }
            set
            {
                _micompra = value;
            }
        }

        public static async void NuevaCompra()
        {
            Compra compra = new Compra();
            await CompraNegocio.Post(compra);
        }

        static readonly string defaultURL = "http://localhost:5108/api/Cliente/" + Convert.ToString(ClienteNegocio.Cliente?.IdUsu) + "/Compra/";
        public static async Task<IEnumerable<Compra>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL);
            return JsonConvert.DeserializeObject<List<Compra>>(response);
        }

        public static async Task<IEnumerable<CompraMuestra>> SetComprasMuestra()
        {
            var compras = await GetAll();
            List<CompraMuestra> comprasMuestra = new List<CompraMuestra>();
            foreach (Compra c in compras)
            {
                CompraMuestra compraMuestra = new CompraMuestra
                {
                    IdOperacion = c.IdOperacion,
                    FechaOperacion = c.FecOperacion,
                    EstadoOperacion = c.EstadoOperacion
                };
                comprasMuestra.Add(compraMuestra);
            }
            return comprasMuestra;
        }

        public static async Task<IEnumerable<Compra>> GetEnProceso()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL + "EnProceso");
            var data = JsonConvert.DeserializeObject<List<Compra>>(response);
            return data;
        }

        public static async Task<Boolean> Post(Compra compra)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL, compra);
            return response.IsSuccessStatusCode;
        }

        public static async Task<Boolean> Put(Compra compra)
        {
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync(defaultURL + compra.IdOperacion, compra);
            return response.IsSuccessStatusCode;
        }

        public static async Task<Boolean> Delete(Compra compra)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync(defaultURL + compra.IdOperacion);
            return response.IsSuccessStatusCode;
        }
    }
}
