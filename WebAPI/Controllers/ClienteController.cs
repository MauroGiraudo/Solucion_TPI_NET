using Microsoft.AspNetCore.Mvc;
using Domain;
using Domain.Model.Usuarios;
using Domain.Services;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly ClienteService _clienteService;

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet(Name = "GetCliente")]
        public ActionResult<IEnumerable<Cliente>> FindAll()
        {
            var clientes = _clienteService.FindAll();
            if (clientes != null)
            {
                return Ok(clientes);
            } else
            {
                return NotFound();
            }
        }

        [HttpGet("{idUsu}")]
        public ActionResult<Cliente> GetById(int idUsu)
        {
            var cliente = _clienteService.GetOne(idUsu);
            if(cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpPost]
        public ActionResult<Cliente> Create(Cliente cliente)
        {
            _clienteService.Add(cliente);
            return CreatedAtAction(nameof(GetById), new { idUsu = cliente.IdUsu }, cliente);
        }

        [HttpPut]
        public ActionResult<Cliente> Update(int idUsu, Cliente cliente)
        {
            if(idUsu != cliente.IdUsu)
            {
                return BadRequest();
            }
            _clienteService.Update(cliente);
            return NoContent();
        }

        [HttpDelete]
        public ActionResult<Cliente> Delete(int idUsu)
        {
            if(!_clienteService.Delete(idUsu))
            {
                return NotFound();
            }
            return Ok(GetById(idUsu));
        }


    }
}
