using Domain.Model.Cargas;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Validations;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/Empleado/{IdUsu}/[controller]")]
    public class CargaController : Controller
    {
        private CargaService _service = new CargaService();
        public CargaService Service
        {
            get
            {
                return _service;
            }
        }

        private EmpleadoService _eservice = new EmpleadoService();
        public EmpleadoService EService
        {
            get
            {
                return _eservice;
            }
        }

        [HttpGet(Name = "GetAllCargas")]
        public ActionResult<IEnumerable<Carga>> GetAll(int IdUsu)
        {
            return Ok(Service.FindAll(IdUsu));
        }

        [HttpGet("{IdOperacion}")]
        public ActionResult<Carga> GetById(int IdUsu, int IdOperacion)
        {
            var carga = Service.GetOne(IdUsu, IdOperacion);
            if(carga == null)
            {
                return NotFound();
            }
            return Ok(carga);
        }

        [HttpPost]
        public ActionResult<Carga> Post(int IdUsu, Carga carga)
        {
            var result = CargaValidation.ParsePost(IdUsu, Service);
            if(result != null)
            {
                return BadRequest(result);
            }
            carga.IdUsu = IdUsu;
            var empleado = EService.GetOne(IdUsu);
            if(empleado == null)
            {
                return NotFound();
            }
            Service.Add(carga);
            return CreatedAtAction(nameof(GetById), new { IdUsu = carga.IdUsu, IdOperacion = carga.IdOperacion }, carga);
        }

        [HttpPut("{IdOperacion}")]
        public ActionResult<Carga> Put(int IdUsu, int IdOperacion, Carga carga)
        {
            if(IdUsu != carga.IdUsu || IdOperacion != carga.IdOperacion)
            {
                return BadRequest();
            }
            Service.Update(carga);
            return NoContent();
        }

        [HttpDelete("{IdOperacion}")]
        public ActionResult<Carga> Delete(int IdUsu, int IdOperacion)
        {
            var carga = Service.GetOne(IdUsu, IdOperacion);
            if(carga == null)
            {
                return NotFound();
            }
            Service.Delete(carga);
            return NoContent();
        }
    }
}
