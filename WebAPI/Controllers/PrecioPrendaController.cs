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

        [HttpPost("{Id}/Precio")]
        public ActionResult<PrecioPrenda> PostPrecioPrenda(int IdPrenda, PrecioPrenda precioPrenda)
        {
            if(IdPrenda != precioPrenda.IdPrenda)
            {
                return BadRequest();
            }
            var precio = PPService.GetOne(precioPrenda.IdPrenda, precioPrenda.FecVigencia);
            if (precio != null)
            {
                return BadRequest();
            }
            var result = PrecioPrendaValidation.Parse(PPService, precioPrenda);
            if (result != null)
            {
                return BadRequest(result);
            }
            PPService.Add(precioPrenda);
            return CreatedAtAction(nameof(GetCurrentPrice), new { IdPrenda = precioPrenda.IdPrenda, FecVigencia = precioPrenda.FecVigencia }, precioPrenda);
        }
    }
}
