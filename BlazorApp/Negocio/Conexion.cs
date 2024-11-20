
namespace BlazorApp.Negocio
{
    public sealed class Conexion
    {
        private Conexion() { }

        private static Conexion? _instancia;

        private HttpClient _cliente = new HttpClient();
        public HttpClient Cliente
        {
            get
            {
                return _cliente;
            }
        }
        public static Conexion Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Conexion();
                    _instancia.Cliente.DefaultRequestHeaders.Accept.Clear();
                    _instancia.Cliente.DefaultRequestHeaders.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                }
                return _instancia;
            }
        }
    }
}