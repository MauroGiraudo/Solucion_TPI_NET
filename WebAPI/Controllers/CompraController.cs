using Domain.Model.Compras;
using Domain.Model.Prendas;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Validations;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/Usuario/{IdUsu}/[controller]")]
    public class CompraController : Controller
    {
        private CompraService _service = new CompraService();
        public CompraService Service
        {
            get
            {
                return _service;
            }
        }

        private UsuarioService _uservice = new UsuarioService();
        public UsuarioService UService
        {
            get
            {
                return _uservice;
            }
        }

        private LineaCompraService _lcservice = new LineaCompraService();
        public LineaCompraService LCService
        {
            get
            {
                return _lcservice;
            }
        }

        private PrendaService _pservice = new PrendaService();
        public PrendaService PService
        {
            get
            {
                return _pservice;
            }
        }

        [HttpGet(Name = "GetAllCompras")]
        public ActionResult<IEnumerable<Compra>> GetAll(int IdUsu)
        {
            return Ok(Service.FindAll(IdUsu));
        }

        [HttpGet("{IdOperacion}")]
        public ActionResult<Compra> GetById(int IdUsu, int IdOperacion)
        {
            var compra = Service.GetOne(IdUsu, IdOperacion);
            if(compra == null)
            {
                return NotFound();
            }
            return Ok(compra);
        }

        [HttpGet("EnProceso")]
        public ActionResult<Compra> GetEnProceso(int IdUsu)
        {
            var compra = Service.GetEnProceso(IdUsu);
            return Ok(compra);
        }

        [HttpPost]
        public ActionResult<Compra> Post(int IdUsu, Compra compra)
        {
            var result = CompraValidation.ParsePost(IdUsu, Service);
            if(result != null)
            {
                return BadRequest(result);
            }
            compra.IdUsu = IdUsu;
            var cliente = UService.GetOne(compra.IdUsu);
            if(cliente == null)
            {
                return NotFound();
            }
            compra.FecOperacion = DateTime.Now;
            compra.EstadoOperacion = "En Proceso";
            Service.Add(compra);
            return CreatedAtAction(nameof(GetById), new { IdUsu = compra.IdUsu }, compra);
        }

        [HttpPut("{IdOperacion}")]
        public ActionResult<Compra> PutFinalizar(int IdUsu, int IdOperacion, Compra compra)
        {
            if (IdOperacion != compra.IdOperacion || IdUsu != compra.IdUsu)
            {
                return BadRequest();
            }
            var cliente = UService.GetOne(compra.IdUsu);
            if(cliente == null)
            {
                return NotFound("Error: No se reconoce al usuario asociado al pedido actual");
            }
            if(cliente.MedioDePago == null)
            {
                return BadRequest("Error: No se ha registrado un medio de pago");
            }
            var comp = Service.GetOne(IdUsu, IdOperacion);
            comp.EstadoOperacion = "Finalizada";

            var lineasCompra = LCService.FindAll(comp.IdUsu, comp.IdOperacion);
            foreach (var lc in lineasCompra)
            {
                int IdPrenda = lc.IdPrenda;
                Prenda? prenda = PService.GetOne(IdPrenda);
                if (prenda == null)
                {
                    return NotFound("Error: Una de las prendas no pudo ser identificada");
                }
                if (prenda.Stock < lc.CantidadPrenda)
                {
                    return BadRequest("Error: No hay suficiente stock de la prenda: " + prenda.Descripcion);
                }
                prenda.Stock -= lc.CantidadPrenda;
                PService.Update(prenda);
            }
            Service.Update(comp);
            return Ok(comp);
        }

        [HttpDelete("{IdOperacion}")]
        public ActionResult<Compra> Delete(int IdUsu, int IdOperacion)
        {
            var c = Service.GetOne(IdUsu, IdOperacion);
            if(c == null)
            {
                return NotFound();
            }
            var result = CompraValidation.ParseDelete(IdUsu, IdOperacion, Service);
            if(result != null)
            {
                return BadRequest(result);
            }
            Service.Delete(c);
            return NoContent();
        }

    }
}
