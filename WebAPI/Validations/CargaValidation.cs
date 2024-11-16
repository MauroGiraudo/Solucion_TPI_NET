using Domain.Services;
using Domain.Model.Compras;

namespace WebAPI.Validations
{
    public class CargaValidation
    {
        public static string? ParsePost(int IdUsu, CargaService service)
        {
            var cargas = service.FindAll(IdUsu);
            var cargasEnCurso = from c in cargas
                                 where c.EstadoOperacion == "En Proceso"
                                select c;
            if (cargasEnCurso.Any())
            {
                return "Ya cuenta con una carga en curso. Finalice la misma para comenzar una nueva carga.";
            }
            return null;
        }
    }
}