using Domain.Model.Prendas;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Validations;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/Prenda/{IdPrenda}/[controller]")]
    public class PrecioPrendaController : Controller
    {
        private PrecioPrendaService _ppService = new PrecioPrendaService();
        public PrecioPrendaService PPService
        {
            get
            {
                return _ppService;
            }
        }

        [HttpGet(Name = "GetCurrentPrice")]
        public ActionResult<PrecioPrenda> GetCurrentPrice(int IdPrenda)
        {
            var fecha = PPService.GetDate(DateTime.Now);
            if (fecha == null)
            {
                return BadRequest("No hay precios registrados para esta prenda");
            }
            Console.WriteLine(fecha);
            var price = PPService.GetOne(IdPrenda, Convert.ToDateTime(fecha));
            if (price == null)
            {
                return NotFound();
            }
            return Ok(price);
        }

        [HttpPost]
        public ActionResult<PrecioPrenda> Post(int IdPrenda, PrecioPrenda precioPrenda)
        {
            precioPrenda.IdPrenda = IdPrenda;
            var result = PrecioPrendaValidation.Parse(PPService, precioPrenda);
            if (result != null)
            {
                return BadRequest(result);
            }
            precioPrenda.FecVigencia = DateTime.Now;
            PPService.Add(precioPrenda);
            return CreatedAtAction(nameof(GetCurrentPrice), new { IdPrenda = precioPrenda.IdPrenda, FecVigencia = precioPrenda.FecVigencia }, precioPrenda);
        }
    }
}
