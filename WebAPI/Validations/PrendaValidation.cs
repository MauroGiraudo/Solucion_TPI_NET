using Domain.Model.Prendas;
using Domain.Services;

namespace WebAPI.Validations
{
    public class  PrendaValidation
    {
        public static string[] tallas = ["S", "M", "L", "XL"]; //Establecer en un combo box las tallas posibles al subir una nueva prenda
        public static string? Parse(PrendaService service, Prenda prenda)
        {
            var prendas = service.FindAll();
            foreach (Prenda p in prendas)
            {
                if (p.Descripcion == prenda.Descripcion && p.Talla == prenda.Talla)
                {
                    return "La prenda ya existe";
                }
            }
            if (prenda.Stock < 0)
            {
                return "El stock no puede ser negativo";
            }
            if (prenda.PuntoPedido < 0)
            {
                return "El punto de pedido no puede ser negativo";
            }
            if (!tallas.Contains(prenda.Talla))
            {
                return "Las tallas deben ser S, M, L o XL";
            }
            return null;

        }
    }
}