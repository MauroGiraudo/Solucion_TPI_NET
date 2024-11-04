using Domain.Model.Prendas;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Validations;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoPrendaController : Controller
    {
        private TipoPrendaService _service = new TipoPrendaService();

        public TipoPrendaService Service
        {
            get
            {
                return _service;
            }
        }

        [HttpGet(Name = "GetTiposDePrenda")]
        public ActionResult<IEnumerable<TipoPrenda>> GetAll()
        {
            return Ok(Service.FindAll());
        }

        [HttpGet("{Id}")]
        public ActionResult<TipoPrenda> GetById(int Id)
        {
            var tipoPrenda = Service.GetOne(Id);
            if (tipoPrenda == null)
            {
                return NotFound();
            }
            return Ok(tipoPrenda);
        }

        [HttpPost]
        public ActionResult<TipoPrenda> Post(TipoPrenda tipoPrenda)
        {
            var tp = Service.GetOne(tipoPrenda.IdTipoPrenda);
            if(tp != null)
            {
                return BadRequest();
            }
            var result = TipoPrendaValidation.Parse(Service, tipoPrenda);
            if(result != null)
            {
                return BadRequest(result);
            }
            Service.Add(tipoPrenda);
            return CreatedAtAction(nameof(GetById), new { Id = tipoPrenda.IdTipoPrenda }, tipoPrenda);

        }

        [HttpPut("{Id}")]
        public ActionResult<TipoPrenda> Put(int Id, TipoPrenda tipoPrenda)
        {
            if (Id != tipoPrenda.IdTipoPrenda)
            {
                return BadRequest();
            }
            var result = TipoPrendaValidation.Parse(Service, tipoPrenda);
            if(result != null)
            {
                return BadRequest(result);
            }
            Service.Update(tipoPrenda);
            return NoContent();
        }

        [HttpDelete("{Id}")]
        public ActionResult<TipoPrenda> Delete(int Id)
        {
            var tp = Service.GetOne(Id);
            if (tp != null)
            {
                Service.Delete(tp);
                return NoContent();
            }
            return NotFound();
        }
    }
}
