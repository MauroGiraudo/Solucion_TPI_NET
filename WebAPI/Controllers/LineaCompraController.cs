using Microsoft.AspNetCore.Mvc;
using Domain.Model.Compras;
using Domain.Services;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Domain.Model.Shared;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class LineaCompraController : Controller
    {
        private readonly LineaCompraService _lineaCompraService;

        public LineaCompraController(LineaCompraService lineaCompraService)
        {
            _lineaCompraService = lineaCompraService;
        }

        [HttpGet(Name = "GetLineaCompra")]
        public ActionResult<IEnumerable<LineaCompra>> FindAll()
        {
            var lineasCompra = _lineaCompraService.FindAll();
            if (lineasCompra != null)
            {
                return Ok(lineasCompra);
            } else
            {
                return NotFound();
            }
        }

        [HttpGet("{NumeroLinea}/{IdOperacion}")]
        public ActionResult<LineaCompra> GetById(int NumeroLinea, int IdOperacion)
        {
            var lineaCompra = _lineaCompraService.GetOne(NumeroLinea, IdOperacion);
            if(lineaCompra == null)
            {
                return NotFound();
            }
            return Ok(lineaCompra);
        }

        [HttpPost]
        public ActionResult<LineaCompra> Create(LineaCompra lineaCompra)
        {
            _lineaCompraService.Add(lineaCompra);
            return CreatedAtAction(nameof(GetById), new { NumeroLinea = lineaCompra.NumeroLinea }, lineaCompra);
        }

        [HttpPut]
        public ActionResult<LineaCompra> Update(int NumeroLinea, int IdOperacion, LineaCompra lineaCompra)
        {
            if(NumeroLinea != lineaCompra.NumeroLinea | IdOperacion != lineaCompra.Compra.IdOperacion)
            {
                return BadRequest();
            }
            _lineaCompraService.Update(lineaCompra, NumeroLinea, IdOperacion);
            return NoContent();
        }

        [HttpDelete]
        public ActionResult<LineaCompra> Delete(int NumeroLinea, int IdOperacion)
        {
            if(!_lineaCompraService.Delete(NumeroLinea, IdOperacion))
            {
                return NotFound();
            }
            return Ok(GetById(NumeroLinea, IdOperacion));
        }
    }
}
