using Domain.Model.Usuarios;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Validations;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpleadoController : Controller
    {
        private EmpleadoService _service = new EmpleadoService();
        public EmpleadoService Service
        {
            get
            {
                return _service;
            }
        }
        [HttpGet(Name = "GetEmpleados")]
        public ActionResult<IEnumerable<Empleado>> GetAll()
        {
            return Ok(Service.FindAll());
        }

        [HttpGet("{Id}")]
        public ActionResult<Empleado> GetById(int Id)
        {
            var empleado = Service.GetOne(Id);
            if(empleado == null)
            {
                return NotFound();
            }
            return Ok(empleado);
        }

        [HttpPost]
        public ActionResult<Empleado> Post(Empleado empleado)
        {
            var cli = Service.GetOne(empleado.IdUsu);
            if(cli != null)
            {
                return BadRequest();
            }
            var result = EmpleadoValidation.Parse(Service, empleado);
            if(result != null)
            {
                return BadRequest(result);
            }
            empleado.TipoUsuario = "Empleado";
            Service.Add(empleado);
            return CreatedAtAction(nameof(GetById), new { IdUsu = empleado.IdUsu }, empleado);
        }

        [HttpPut("{Id}")]
        public ActionResult<Empleado> Put(int Id, Empleado empleado)
        {
            if(Id != empleado.IdUsu)
            {
                return BadRequest();
            }
            var result = EmpleadoValidation.Parse(Service, empleado);
            if(result != null)
            {
                return BadRequest(result);
            }
            Service.Update(empleado);
            return NoContent();
        }

        [HttpDelete("{Id}")]
        public ActionResult<Empleado> Delete(int Id)
        {
            var empleado = Service.GetOne(Id);
            if(empleado == null)
            {
                return NotFound();
            }
            Service.Delete(empleado);
            return NoContent();
        }
    }
}
