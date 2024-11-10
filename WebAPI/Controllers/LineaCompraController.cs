using Domain.Model.Compras;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Validations;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/Cliente/{IdUsu}/Compra/{IdOperacion}/[controller]")]
    public class LineaCompraController : Controller
    {
        private LineaCompraService _service = new LineaCompraService();
        public LineaCompraService Service
        {
            get
            {
                return _service;
            }
        }
        private CompraService _compraService = new CompraService();
        public CompraService CompraService
        {
            get
            {
                return _compraService;
            }
        }
        private ClienteService _clienteService = new ClienteService();
        public ClienteService ClienteService
        {
            get
            {
                return _clienteService;
            }
        }

        private PrendaService _prendaService = new PrendaService();
        public PrendaService PrendaService
        {
            get
            {
                return _prendaService;
            }
        }

        [HttpGet(Name = "GetLineasDeCompra")]
        public ActionResult<IEnumerable<LineaCompra>> GetAll(int IdUsu, int IdOperacion)
        {
            return Ok(Service.FindAll(IdUsu, IdOperacion));
        }

        [HttpGet("{NumeroLinea}")]
        public ActionResult<LineaCompra> GetOne(int IdUsu, int IdOperacion, int NumeroLinea)
        {
            var lineaCompra = Service.GetOne(IdUsu, IdOperacion, NumeroLinea);
            if(lineaCompra == null)
            {
                return NotFound();
            }
            return Ok(lineaCompra);
        }

        [HttpPost]
        public ActionResult<LineaCompra> Post(int IdUsu, int IdOperacion, LineaCompra lineaCompra)
        {
            var result = LineaCompraValidation.Parse(Service, lineaCompra);
            if(result != null)
            {
                return BadRequest(result);
            }
            lineaCompra.IdUsu = IdUsu;
            lineaCompra.IdOperacion = IdOperacion;

            var prenda = PrendaService.GetOne(lineaCompra.IdPrenda);
            if(prenda == null)
            {
                return NotFound("Prenda no encontrada");
            }
            if(prenda.Stock < lineaCompra.CantidadPrenda)
            {
                return BadRequest("No hay suficiente stock de la prenda [ " + prenda.Stock + " ]");
            }

            var lineasDeCompra = Service.FindAll(IdUsu, IdOperacion);
            if(lineasDeCompra.Any())
            {
                foreach (LineaCompra lc in lineasDeCompra)
                {
                    if (lc.IdPrenda == lineaCompra.IdPrenda)
                    {
                        lc.CantidadPrenda = lineaCompra.CantidadPrenda;
                        Service.Update(lc);
                        return Ok("Cantidad de la prenda del pedido [ "+ lc.CantidadPrenda +" ] actualizada");
                    }
                }
            }
            Service.Add(lineaCompra);
            return CreatedAtAction(nameof(GetOne), new { IdUsu = lineaCompra.IdUsu, IdOperacion = lineaCompra.IdOperacion, NumeroLinea = lineaCompra.NumeroLinea }, lineaCompra);
        }

        [HttpPut("{NumeroLinea}")]
        public ActionResult<LineaCompra> Put(int IdUsu, int IdOperacion, int NumeroLinea, LineaCompra lineaCompra)
        {
            if (lineaCompra.IdUsu != IdUsu || lineaCompra.IdOperacion != IdOperacion || lineaCompra.NumeroLinea != NumeroLinea)
            {
                return BadRequest();
            }
            var result = LineaCompraValidation.Parse(Service, lineaCompra);
            if (result != null)
            {
                return BadRequest(result);
            }
            Service.Update(lineaCompra);
            return NoContent();
        }

        [HttpDelete("{NumeroLinea}")]
        public ActionResult<LineaCompra> Delete(int IdUsu, int IdOperacion, int NumeroLinea)
        {
            var lineaCompra = Service.GetOne(IdUsu, IdOperacion, NumeroLinea);
            if (lineaCompra == null)
            {
                return NotFound();
            }
            Service.Delete(lineaCompra);
            return NoContent();
        }
    }
}
