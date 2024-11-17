

using Domain.Model.Prendas;
using Domain.Services;

namespace WebAPI.Validations
{
    public class PrecioPrendaValidation
    {
        public static string? Parse(PrecioPrendaService service, PrecioPrenda precioPrenda)
        {
            var precios = service.FindAll(precioPrenda.IdPrenda);
            foreach(PrecioPrenda p in precios)
            {
                if(p.IdPrenda == precioPrenda.IdPrenda && p.FecVigencia == precioPrenda.FecVigencia)
                {
                    return "Ya existe un precio para esta prenda con vigencia a partir de la fecha ingresada";
                }
            }
            if(precioPrenda.Valor < 0)
            {
                return "El precio de la prenda no puede ser menor a 0";
            }
            return null;
        }
    }
}