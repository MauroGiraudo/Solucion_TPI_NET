using Microsoft.AspNetCore.Mvc;
using Domain.Model.Compras;
using Domain.Services;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Domain.Model.Shared;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CompraController : Controller
    {
        private readonly CompraService _compraService;

        public CompraController(CompraService compraService)
        {
            _compraService = compraService;
        }

        [HttpGet(Name = "GetCompra")]
        public ActionResult<IEnumerable<Compra>> FindAll()
        {
            var compras = _compraService.FindAll();
            if (compras != null)
            {
                return Ok(compras);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{IdOperacion}")]
        public ActionResult<Compra> GetById(int IdOperacion)
        {
            var compra = _compraService.GetOne(IdOperacion);
            if (compra == null)
            {
                return NotFound();
            }
            return Ok(compra);
        }

        [HttpPost]
        public ActionResult<Compra> Create(Compra compra)
        {
            _compraService.Add(compra);
            return CreatedAtAction(nameof(GetById), new { IdOperacion = compra.IdOperacion }, compra);
        }

        [HttpPut]
        public ActionResult<Compra> Update(int IdOperacion, Compra compra)
        {
            if (IdOperacion != compra.IdOperacion)
            {
                return BadRequest();
            }
            _compraService.Update(compra);
            return NoContent();
        }

        [HttpDelete]
        public ActionResult<Compra> Delete(int IdOperacion)
        {
            if (!_compraService.Delete(IdOperacion))
            {
                return NotFound();
            }
            return Ok(GetById(IdOperacion));
        }
    }
}
