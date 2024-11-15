using Domain.Model.Cargas;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Validations;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/Usuario/{IdUsu}/Carga/{IdOperacion}/[controller]")]
    public class LineaCargaController : Controller
    {
        private LineaCargaService _service = new LineaCargaService();
        public LineaCargaService Service
        {
            get
            {
                return _service;
            }
        }
        private CargaService _cargaService = new CargaService();
        public CargaService CargaService
        {
            get
            {
                return _cargaService;
            }
        }
        private UsuarioService _usuarioService = new UsuarioService();
        public UsuarioService UsuarioService
        {
            get
            {
                return _usuarioService;
            }
        }
        [HttpGet(Name = "GetLineasDeCarga")]
        public ActionResult<IEnumerable<LineaCarga>> GetAll(int IdUsu, int IdOperacion)
        {
            return Ok(Service.FindAll(IdUsu, IdOperacion));
        }

        [HttpGet("{NumeroLinea}")]
        public ActionResult<LineaCarga> GetOne(int IdUsu, int IdOperacion, int NumeroLinea)
        {
            var lineaCarga = Service.GetOne(IdUsu, IdOperacion, NumeroLinea);
            if(lineaCarga == null)
            {
                return NotFound();
            }
            return Ok(lineaCarga);
        }

        [HttpPost]
        public ActionResult<LineaCarga> Post(int IdUsu, int IdOperacion, LineaCarga lineaCarga)
        {
            var result = LineaCargaValidation.Parse(Service, lineaCarga);
            if(result != null)
            {
                return BadRequest(result);
            }
            var lineasDeCarga = Service.FindAll(IdUsu, IdOperacion);
            if (lineasDeCarga.Any())
            {
                foreach(LineaCarga lc in lineasDeCarga)
                {
                    if(lc.IdPrenda == lineaCarga.IdPrenda)
                    {
                        lc.CantidadPrenda = lineaCarga.CantidadPrenda;
                        Service.Update(lc);
                        return Ok("La cantidad de la prenda a cargar [ " + lc.CantidadPrenda + " ] ha sido actualizada");
                    }
                }
            }
            Service.Add(lineaCarga);
            return CreatedAtRoute(nameof(GetOne), new {IdUsu = IdUsu, IdOperacion = IdOperacion, NumeroLinea = lineaCarga.NumeroLinea}, lineaCarga);
        }

        [HttpPut("{NumeroLinea}")]
        public ActionResult<LineaCarga> Put(int IdUsu, int IdOperacion, int NumeroLinea, LineaCarga lineaCarga)
        {
            if (lineaCarga.IdUsu != IdUsu || lineaCarga.IdOperacion != IdOperacion || lineaCarga.NumeroLinea != NumeroLinea)
            {
                return BadRequest();
            }
            var result = LineaCargaValidation.Parse(Service, lineaCarga);
            if (result != null)
            {
                return BadRequest(result);
            }
            Service.Update(lineaCarga);
            return NoContent();
        }

        [HttpDelete("{NumeroLinea}")]
        public ActionResult<LineaCarga> Delete(int IdUsu, int IdOperacion, int NumeroLinea)
        {
            var lineaCarga = Service.GetOne(IdUsu, IdOperacion, NumeroLinea);
            if (lineaCarga == null)
            {
                return NotFound();
            }
            Service.Delete(lineaCarga);
            return NoContent();
        }
    }
}
