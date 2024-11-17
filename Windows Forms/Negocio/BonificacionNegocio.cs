using Newtonsoft.Json;
using Windows_Forms.Model.Compras;
using Windows_Forms.Shared;

namespace Windows_Forms.Negocio
{
    public class BonificacionNegocio
    {
        /*private static Bonificacion? _bonificacion;

        public static Bonificacion? Bonificacion
        {
            get
            {
                return _bonificacion;
            }
            set
            {
                _bonificacion = value;
            }
        }*/

        static readonly string defaultURL = "http://localhost:5108/api/Bonificacion/";

        public static async Task<IEnumerable<Bonificacion>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL);
            var data = JsonConvert.DeserializeObject<List<Bonificacion>>(response);
            return data;
        }

        public static async Task<Bonificacion>? GetCurrent(int CantidadParaDescuento)
        {
            var bonificaciones = await GetAll();
            var filtradoValor =
                from b in bonificaciones
                where b.FecVigenciaBonificacion.Date <= DateTime.Now.Date && b.CantidadParaDescuento <= CantidadParaDescuento
                select b.CantidadParaDescuento;
            int? valor = filtradoValor.Any() ? filtradoValor.Max() : (int?)null;
            if (valor == null) return null;
            var bonificacion =
                from b in bonificaciones
                where b.CantidadParaDescuento == valor
                orderby b.FecVigenciaBonificacion descending
                select b;
            return bonificacion.FirstOrDefault();
        }

        public static async Task<Boolean> Post(Bonificacion bonificacion)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL, bonificacion);
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

        public static async Task<Boolean> Put(Bonificacion bonificacion)
        {
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync(defaultURL + bonificacion.IdBonificacion, bonificacion);
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

        public static async Task<Boolean> Delete(Bonificacion bonificacion)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync(defaultURL + bonificacion.IdBonificacion);
            return response.IsSuccessStatusCode;
        }
    }
}