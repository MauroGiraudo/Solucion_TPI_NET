using Domain.Model.Usuarios;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Validations;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private ClienteService _service = new ClienteService();
        public ClienteService Service
        {
            get
            {
                return _service;
            }
        }
        [HttpGet(Name = "GetClientes")]
        public ActionResult<IEnumerable<Cliente>> GetAll()
        {
            return Ok(Service.FindAll());
        }

        [HttpGet("{Id}")]
        public ActionResult<Cliente> GetById(int Id)
        {
            var cliente = Service.GetOne(Id);
            if(cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpPost]
        public ActionResult<Cliente> Post(Cliente cliente)
        {
            var result = ClienteValidation.Parse(Service, cliente);
            if(result != null)
            {
                return BadRequest(result);
            }
            cliente.TipoUsuario = "Cliente";
            Service.Add(cliente);
            return CreatedAtAction(nameof(GetById), new { IdUsu = cliente.IdUsu }, cliente);
        }

        [HttpPut("{Id}")]
        public ActionResult<Cliente> Put(int Id, Cliente cliente)
        {
            if(Id != cliente.IdUsu)
            {
                return BadRequest();
            }
            var result = ClienteValidation.Parse(Service, cliente);
            if(result != null)
            {
                return BadRequest(result);
            }
            Service.Update(cliente);
            return NoContent();
        }

        [HttpDelete("{Id}")]
        public ActionResult<Cliente> Delete(int Id)
        {
            var cliente = Service.GetOne(Id);
            if(cliente == null)
            {
                return NotFound();
            }
            Service.Delete(cliente);
            return NoContent();
        }
    }
}
