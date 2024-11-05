using Domain.Services;
using Domain.Model.Compras;

namespace WebAPI.Validations
{
    public class CompraValidation
    {
        public static string? ParsePost(int IdUsu, CompraService service)
        {
            var compras = service.FindAll(IdUsu);
            var comprasEnCurso = from c in compras
                                 where c.EstadoOperacion == "En Curso"
                                 select c;
            if (comprasEnCurso.Any())
            {
                return "Ya cuenta con una compra en curso. Finalice la misma para comenzar una nueva compra.";
            }
            return null;
        }
    }
}