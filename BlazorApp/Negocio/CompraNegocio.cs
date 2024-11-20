using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorApp.Model.Compras;
using Newtonsoft.Json;

namespace BlazorApp.Negocio
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

        private static CompraMuestra? _compraMuestra = null;
        public static CompraMuestra? CompraMuestra
        {
            get
            {
                return _compraMuestra;
            }
            set
            {
                _compraMuestra = value;
            }
        }

        public static async Task NuevaCompra()
        {
            Compra compra = new Compra();
            await Post(compra);
            var result = await GetEnProceso();
            MiCompra = result.FirstOrDefault();
        }

        //static readonly string defaultURL = "http://localhost:5108/api/Usuario/" + Convert.ToString(UsuarioNegocio.Usuario?.IdUsu) + "/Compra/";
        
        private static string GetURL(int IdUsu)
        {
            return "http://localhost:5108/api/Usuario/" + Convert.ToString(IdUsu) + "/Compra/";
        }
        public static async Task<IEnumerable<Compra>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(GetURL(UsuarioNegocio.Usuario.IdUsu));
            return JsonConvert.DeserializeObject<List<Compra>>(response);
        }

        public async static Task<Compra> GetOne(int IdOperacion)
        {
            var compras = await GetAll();
            var filtrado =
                from c in compras
                where c.IdOperacion == IdOperacion
                select c;
            return filtrado.FirstOrDefault();
        }

        public static CompraMuestra SetOneCompraMuestra(Compra compra)
        {
            CompraMuestra compraMuestra = new CompraMuestra
            {
                IdOperacion = compra.IdOperacion,
                FechaOperacion = compra.FecOperacion,
                EstadoOperacion = compra.EstadoOperacion
            };
            return compraMuestra;
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
            var response = await Conexion.Instancia.Cliente.GetStringAsync(GetURL(UsuarioNegocio.Usuario.IdUsu) + "EnProceso");
            var data = JsonConvert.DeserializeObject<List<Compra>>(response);
            return data;
        }

        public static async Task<Boolean> Post(Compra compra)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(GetURL(UsuarioNegocio.Usuario.IdUsu), compra);
            return response.IsSuccessStatusCode;
        }

        public static async Task<Boolean> Put(Compra compra)
        {
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync(GetURL(UsuarioNegocio.Usuario.IdUsu) + compra.IdOperacion, compra);
            return response.IsSuccessStatusCode;
        }

        public static async Task<Boolean> Delete(Compra compra)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync(GetURL(UsuarioNegocio.Usuario.IdUsu) + compra.IdOperacion);
            return response.IsSuccessStatusCode;
        }
    }
}
