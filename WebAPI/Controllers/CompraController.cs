using Domain.Model.Compras;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Validations;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/Cliente/{IdUsu}/[controller]")]
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

        private ClienteService _cservice = new ClienteService();
        public ClienteService CService
        {
            get
            {
                return _cservice;
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

        [HttpPost]
        public ActionResult<Compra> Post(int IdUsu, Compra compra)
        {
            var result = CompraValidation.ParsePost(IdUsu, Service);
            if(result != null)
            {
                return BadRequest(result);
            }
            compra.IdUsu = IdUsu;
            var cliente = CService.GetOne(compra.IdUsu);
            if(cliente == null)
            {
                return NotFound();
            }
            Service.Add(compra);
            return CreatedAtAction(nameof(GetById), new { IdUsu = compra.IdUsu }, compra);
        }

        [HttpPut("{IdOperacion}")]
        public ActionResult<Compra> Put(int IdUsu, int IdOperacion, Compra compra)
        {
            if(IdOperacion != compra.IdOperacion || IdUsu != compra.IdUsu)
            {
                return BadRequest();
            }
            Service.Update(compra);
            return NoContent();
        }

        [HttpDelete("{IdOperacion}")]
        public ActionResult<Compra> Delete(int IdUsu, int IdOperacion)
        {
            var c = Service.GetOne(IdUsu, IdOperacion);
            if(c == null)
            {
                return NotFound();
            }
            Service.Delete(c);
            return NoContent();
        }

    }
}
