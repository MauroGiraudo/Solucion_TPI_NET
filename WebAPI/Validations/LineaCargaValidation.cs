using Domain.Services;
using Domain.Model.Cargas;

namespace WebAPI.Validations
{
    public class LineaCargaValidation
    {
        public static string? Parse(LineaCargaService service, LineaCarga lineaCarga)
        {
            if(lineaCarga.CantidadPrenda < 1)
            {
                return "La cantidad de prendas debe ser mayor a 0";
            }
            return null;
        }
    }
}