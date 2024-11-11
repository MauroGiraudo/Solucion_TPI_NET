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

        [HttpPost("login")]
        public ActionResult<Cliente> Login(LoginData login)
        {
            if (!ClienteValidation.IsValidUserName(login.UserName))
            {
                return BadRequest("El usuario ingresado no es válido");
            }
            if (!ClienteValidation.IsValidPassword(login.Contrasenia))
            {
                return BadRequest("La contraseña no debe contener más de 50 caracteres");
            }
            var clienteResultado = Service.GetOneByUser(login.UserName);

            if (!clienteResultado.Any()) return NotFound("No existe un cliente con el usuario ingresado");

            Cliente cliente = clienteResultado.Single();

            if(cliente.Contrasenia != login.Contrasenia)
            {
                return BadRequest("La contraseña ingresada no es correcta");
            }
            IEnumerable<Cliente> client = new List<Cliente> { cliente };
            return Ok(client);
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
            return Ok(cliente);
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
