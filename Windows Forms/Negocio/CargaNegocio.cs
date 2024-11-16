using Windows_Forms.Model.Cargas;
using Newtonsoft.Json;
using Windows_Forms.Shared;
using Windows_Forms.Model.Compras;

namespace Windows_Forms.Negocio
{
    public class CargaNegocio
    {
        private static Carga? _miCarga = null;

        public static IEnumerable<Carga> Cargar_Carga()
        {
            var result = GetEnProceso();
            return result.Result;
        }
        public static Carga? MiCarga
        {
            get
            {
                if(_miCarga == null)
                {
                    Task<IEnumerable<Carga>> task = new Task<IEnumerable<Carga>>(Cargar_Carga);
                    task.Start();
                    var cargaResult = task.Result;
                    _miCarga = cargaResult.First();
                }
                return _miCarga;
            }
            set
            {
                _miCarga = value;
            }
        }

        private static CargaMuestra? _cargaMuestra = null;
        public static CargaMuestra? CargaMuestra
        {
            get
            {
                return _cargaMuestra;
            }
            set
            {
                _cargaMuestra = value;
            }
        }

        public async static void NuevaCarga()
        {
            Carga carga = new Carga();
            await Post(carga);
        }

        static readonly string defaultURL = "http://localhost:5108/api/Usuario/" + Convert.ToString(UsuarioNegocio.Usuario?.IdUsu) + "/Carga/";
        public async static Task<IEnumerable<Carga>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL);
            var data = JsonConvert.DeserializeObject<List<Carga>>(response);
            return data;
        }

        public static async Task<IEnumerable<CargaMuestra>> SetCargasMuestra()
        {
            var cargas = await GetAll();
            List<CargaMuestra> cargasMuestra = new List<CargaMuestra>();
            foreach (Carga c in cargas)
            {
                CargaMuestra cargaMuestra = new CargaMuestra
                {
                    IdOperacion = c.IdOperacion,
                    FechaOperacion = c.FecOperacion,
                    EstadoOperacion = c.EstadoOperacion
                };
                cargasMuestra.Add(cargaMuestra);
            }
            return cargasMuestra;
        }

        public static async Task<IEnumerable<Carga>> GetEnProceso()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL + "EnProceso");
            var data = JsonConvert.DeserializeObject<List<Carga>>(response);
            return data;
        }
        public static async Task<Boolean> Post(Carga carga)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL, carga);
            return response.IsSuccessStatusCode;
        }

        public static async Task<Boolean> Put(Carga carga)
        {
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync(defaultURL + carga.IdOperacion, carga);
            return response.IsSuccessStatusCode;
        }

        public static async Task<Boolean> Delete(Carga carga)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync(defaultURL + carga.IdOperacion);
            return response.IsSuccessStatusCode;
        }
    }
}