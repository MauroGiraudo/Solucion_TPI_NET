using Domain.Model.Prendas;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Validations;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrendaController : Controller
    {
        private PrendaService _service = new PrendaService();

        public PrendaService Service
        {
            get
            {
                return _service;
            }
        }

        private TipoPrendaService _tpService = new TipoPrendaService();

        public TipoPrendaService TPService
        {
            get
            {
                return _tpService;
            }
        }

        private MarcaService _mService = new MarcaService();

        public MarcaService MService
        {
            get
            {
                return _mService;
            }
        }

        [HttpGet(Name = "GetPrendas")]
        public ActionResult<IEnumerable<Prenda>> GetAll()
        {
            return Ok(Service.FindAll());
        }

        [HttpGet("{Id}")]
        public ActionResult<Prenda> GetById(int Id)
        {
            var m = Service.GetOne(Id);
            if (m == null)
            {
                return NotFound();
            }
            return Ok(m);
        }

        [HttpPost]
        public ActionResult<Prenda> Post(Prenda prenda)
        {
            var m = Service.GetOne(prenda.IdPrenda);
            if (m != null)
            {
                return BadRequest();
            }

            var result = PrendaValidation.Parse(Service, prenda);
            if (result != null)
            {
                return BadRequest(result);
            }

            var tipoPrenda = TPService.GetOne(prenda.IdTipoPrenda);
            var marca = MService.GetOne(prenda.IdMarca);
            if (tipoPrenda == null || marca == null)
            {
                return BadRequest("La marca y/o el tipo de prenda ingresados son incorrectos");
            }
            //Probar a eliminar la asignación de tipo y marca y probar

            /*prenda.TipoDePrenda = tipoPrenda;
            prenda.MarcaPrenda = marca;*/
            Service.Add(prenda);
            return CreatedAtAction(nameof(GetById), new { Id = prenda.IdPrenda }, prenda);


        }

        [HttpPut("{Id}")]
        public ActionResult<Prenda> Put(int Id, Prenda prenda)
        {
            if (Id != prenda.IdPrenda)
            {
                return BadRequest();
            }

            var result = PrendaValidation.Parse(Service, prenda);
            if (result != null)
            {
                return BadRequest(result);
            }

            Service.Update(prenda);
            return NoContent();
        }

        [HttpDelete("{Id}")]
        public ActionResult<Prenda> Delete(int Id)
        {
            var m = Service.GetOne(Id);
            if (m == null)
            {
                return NotFound();
            }
            Service.Delete(m);
            return NoContent();
        }
    }
}
