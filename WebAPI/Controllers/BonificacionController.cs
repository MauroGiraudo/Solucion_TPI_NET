using Domain.Model.Compras;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Validations;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BonificacionController : Controller
    {
        private BonificacionService _service = new BonificacionService();
        public BonificacionService Service
        {
            get
            {
                return _service;
            }
        }

        [HttpGet(Name = "GetAllBonificaciones")]
        public ActionResult<IEnumerable<Bonificacion>> GetAll()
        {
            return Ok(Service.FindAll());
        }

        [HttpGet("{IdBonificacion}")]
        public ActionResult<Bonificacion> GetById(int IdBonificacion)
        {
            var bonif = Service.GetOne(IdBonificacion);
            if(bonif == null)
            {
                return NotFound();
            }
            return Ok(bonif);
        }

        [HttpPost]
        public ActionResult<Bonificacion> Post(Bonificacion bonificacion)
        {
            var result = BonificacionValidation.ParsePost(Service, bonificacion);
            if (result != null)
            {
                return BadRequest(result);
            }
            bonificacion.FecVigenciaBonificacion = DateTime.Now;
            Service.Add(bonificacion);
            return CreatedAtAction(nameof(GetById), new { IdBonificacion = bonificacion.IdBonificacion }, bonificacion);
        }

        [HttpPut("{IdBonificacion}")]
        public ActionResult<Bonificacion> Put(int IdBonificacion, Bonificacion bonificacion)
        {
            if (IdBonificacion != bonificacion.IdBonificacion)
            {
                return BadRequest();
            }
            var result = BonificacionValidation.ParsePut(Service, bonificacion);
            if (result != null)
            {
                return BadRequest(result);
            }
            bonificacion.FecVigenciaBonificacion = DateTime.Now;
            Service.Update(bonificacion);
            return NoContent();
        }

        [HttpDelete("{IdBonificacion}")]
        public ActionResult<Bonificacion> Delete(int IdBonificacion)
        {
            var bonif = Service.GetOne(IdBonificacion);
            if(bonif == null)
            {
                return NotFound();
            }
            Service.Delete(bonif);
            return NoContent();
        }
    }
}
