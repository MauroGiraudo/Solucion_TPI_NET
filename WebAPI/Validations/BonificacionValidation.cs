using Domain.Services;
using Microsoft.Identity.Client;
using Domain.Model.Compras;

namespace WebAPI.Validations
{
    public class BonificacionValidation
    {
        public static string? ParsePost(BonificacionService service, Bonificacion bonificacion)
        {
            var bonificaciones = service.FindAll();
            foreach(Bonificacion b in bonificaciones)
            {
                if(bonificacion.ProporcionDescuento == b.ProporcionDescuento)
                {
                    return "Ya existe una bonificación con el porcentaje de descuento ingresado";
                }
                if (bonificacion.CantidadParaDescuento == b.CantidadParaDescuento && bonificacion.FecVigenciaBonificacion.Date == b.FecVigenciaBonificacion.Date)
                {
                    return "Ya existe una bonificación para la cantidad ingresada";
                }
            }
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
        public static string? ParsePut(BonificacionService service, Bonificacion bonificacion)
        {
            if (bonificacion.ProporcionDescuento < 0 || bonificacion.ProporcionDescuento > 100)
            {
                return "El descuento debe encontrarse entre 0% y 100%";
            }
            if (bonificacion.CantidadParaDescuento < 0)
            {
                return "La cantidad para agregar el descuento no puede ser menor a 0";
            }
            return null;

        }
    }
}