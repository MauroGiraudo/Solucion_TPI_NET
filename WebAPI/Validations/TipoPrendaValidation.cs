using Domain.Services;
using Domain.Model.Prendas;

namespace WebAPI.Validations
{
    public class TipoPrendaValidation
    {
        public static string? Parse(TipoPrendaService service, TipoPrenda tipoPrenda)
        {
            var tiposPrenda = service.FindAll();
            foreach (TipoPrenda tp in tiposPrenda)
            {
                if (tp.DescripcionTipoPrenda == tipoPrenda.DescripcionTipoPrenda)
                {
                    return "El tipo de prenda ya existe";
                }
            }
            return null;
        }
    }
}