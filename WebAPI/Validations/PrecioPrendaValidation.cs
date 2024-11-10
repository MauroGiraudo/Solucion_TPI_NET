

using Domain.Model.Prendas;
using Domain.Services;

namespace WebAPI.Validations
{
    public class PrecioPrendaValidation
    {
        public static string? Parse(PrecioPrendaService service, PrecioPrenda precioPrenda)
        {
            if(precioPrenda.Valor < 0)
            {
                return "El precio de la prenda no puede ser menor a 0";
            }
            return null;
        }
    }
}