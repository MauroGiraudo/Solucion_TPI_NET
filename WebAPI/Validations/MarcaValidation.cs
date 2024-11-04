using Domain.Services;
using Domain.Model.Prendas;

namespace WebAPI.Validations
{
    public class MarcaValidation
    {
        public static string? Parse(MarcaService service, Marca marca)
        {
            var marcas = service.FindAll();
            foreach (Marca m in marcas)
            {
                if (m.DescripcionMarca == marca.DescripcionMarca)
                {
                    return "La marca ya existe";
                }
            }
            return null;
        }
    }
}