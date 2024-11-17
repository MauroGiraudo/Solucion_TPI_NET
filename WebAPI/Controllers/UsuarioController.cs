using Domain.Model.Usuarios;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Validations;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private UsuarioService _service = new UsuarioService();
        public UsuarioService Service
        {
            get
            {
                return _service;
            }
        }
        [HttpGet(Name = "GetUsuarios")]
        public ActionResult<IEnumerable<Usuario>> GetAll()
        {
            return Ok(Service.FindAll());
        }

        [HttpGet("{IdUsu}")]
        public ActionResult<Usuario> GetById(int IdUsu)
        {
            var usuario = Service.GetOne(IdUsu);
            if(usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        [HttpPost]
        public ActionResult<Usuario> Post(Usuario usuario)
        {
            var result = UsuarioValidation.Parse(Service, usuario);
            if(result != null)
            {
                return BadRequest(result);
            }
            Service.Add(usuario);
            return CreatedAtAction(nameof(GetById), new { IdUsu = usuario.IdUsu }, usuario);
        }

        [HttpPost("login")]
        public ActionResult<Usuario> Login(LoginData login)
        {
            if (!UsuarioValidation.IsValidUserName(login.UserName))
            {
                return BadRequest("El usuario ingresado no es válido");
            }
            if (!UsuarioValidation.IsValidPassword(login.Contrasenia))
            {
                return BadRequest("La contraseña no debe contener más de 50 caracteres");
            }
            var usuario = Service.GetOneByUser(login.UserName);

            if (usuario == null) return NotFound("No existe un usuario con el nombre de usuario ingresado");

            if(usuario.Contrasenia != login.Contrasenia)
            {
                return BadRequest("La contraseña ingresada no es correcta");
            }
            return Ok(usuario);
        }

        [HttpPut("{Id}")]
        public ActionResult<Usuario> Put(int Id, Usuario usuario)
        {
            if(Id != usuario.IdUsu)
            {
                return BadRequest();
            }
            var result = UsuarioValidation.Parse(Service, usuario);
            if(result != null)
            {
                return BadRequest(result);
            }
            Service.Update(usuario);
            return Ok(usuario);
        }

        [HttpDelete("{Id}")]
        public ActionResult<Usuario> Delete(int Id)
        {
            var usuario = Service.GetOne(Id);
            if(usuario == null)
            {
                return NotFound();
            }
            Service.Delete(usuario);
            return NoContent();
        }
    }
}
