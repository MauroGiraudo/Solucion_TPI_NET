using Domain.Model.Prendas;
using Domain.Services;

namespace WebAPI.Validations
{
    public class  PrendaValidation
    {
        public static string[] tallas = ["S", "M", "L", "XL"];
        public static string? Parse(PrendaService service, Prenda prenda)
        {
            var prendas = service.FindAll();
            foreach (Prenda p in prendas)
            {
                if (p.Descripcion == prenda.Descripcion)
                {
                    return "La prenda ya existe";
                }
                if (p.Stock < 0)
                {
                    return "El stock no puede ser negativo";
                }
                if (p.PuntoPedido < 0)
                {
                    return "El punto de pedido no puede ser negativo";
                }
                foreach(string talla in p.Talla)
                {
                    if (!tallas.Contains(talla))
                    {
                        return "Las tallas deben ser S, M, L o XL";
                    }
                }
            }
            return null;

        }
    }
}