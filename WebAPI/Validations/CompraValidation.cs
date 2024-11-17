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
                                 where c.EstadoOperacion == "En Proceso"
                                 select c;
            if (comprasEnCurso.Any())
            {
                return "Ya cuenta con una compra en curso. Finalice la misma para comenzar una nueva compra.";
            }
            return null;
        }

        public static string? ParseDelete(int IdUsu, int IdOperacion, CompraService service)
        {
            var compras = service.FindAll(IdUsu);
            var comprasFinalizadas = from c in compras
                                     where c.EstadoOperacion == "Finalizada" && c.IdOperacion == IdOperacion
                                     select c;
            if (comprasFinalizadas.Any())
            {
                return "No se puede eliminar la compra porque ya ha sido finalizada.";
            }
            return null;
        }
    }
}