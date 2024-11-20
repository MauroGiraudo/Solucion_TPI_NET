using Domain.Model.Cargas;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Validations;
using Domain.Model.Prendas;
using Domain.Model.Compras;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/Usuario/{IdUsu}/[controller]")]
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

        private UsuarioService _uservice = new UsuarioService();
        public UsuarioService UService
        {
            get
            {
                return _uservice;
            }
        }

        private LineaCargaService _lcservice = new LineaCargaService();
        public LineaCargaService LCService
        {
            get
            {
                return _lcservice;
            }
        }

        private PrendaService _pservice = new PrendaService();
        public PrendaService PService
        {
            get
            {
                return _pservice;
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

        [HttpGet("EnProceso")]
        public ActionResult<Carga> GetEnProceso(int IdUsu)
        {
            var compra = Service.GetEnProceso(IdUsu);
            return Ok(compra);
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
            var empleado = UService.GetOne(IdUsu);
            if(empleado == null)
            {
                return NotFound();
            }
            carga.FecOperacion = DateTime.Now;
            carga.EstadoOperacion = "En Proceso";
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
            carga.EstadoOperacion = "Finalizada";

            var lineasCarga = LCService.FindAll(IdUsu, IdOperacion);
            
            foreach(var lc in lineasCarga)
            {
                int idPrenda = lc.IdPrenda;
                Prenda? prenda = PService.GetOne(idPrenda);
                if(prenda == null)
                {
                    return NotFound("Error: Una de las prendas no pudo ser identificada");
                }
                prenda.Stock += lc.CantidadPrenda;
                PService.Update(prenda);
            }

            Service.Update(carga);
            return Ok(carga);
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
