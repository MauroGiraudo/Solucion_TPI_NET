using Domain.Services;
using Domain.Model.Compras;

namespace WebAPI.Validations
{
    public class LineaCompraValidation
    {
        public static string? Parse(LineaCompraService service, LineaCompra lineaCompra)
        {
            if(lineaCompra.CantidadPrenda < 1)
            {
                return "La cantidad de prendas debe ser mayor a 0";
            }
            return null;
        }
    }
}