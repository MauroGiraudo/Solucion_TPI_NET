using Domain.Services;
using Microsoft.Identity.Client;
using Domain.Model.Compras;

namespace WebAPI.Validations
{
    public class BonificacionValidation
    {
        public static string? Parse(BonificacionService service, Bonificacion bonificacion)
        {
            if(bonificacion.ProporcionDescuento < 0 || bonificacion.ProporcionDescuento > 100)
            {
                return "El descuento debe encontrarse entre 0% y 100%";
            }
            if(bonificacion.CantidadParaDescuento < 0)
            {
                return "La cantidad para agregar el descuento no puede ser menor a 0";
            }
            return null;

        }
    }
}