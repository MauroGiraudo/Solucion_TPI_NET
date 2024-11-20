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

        private LineaCompraService _lcService = new LineaCompraService();

        public LineaCompraService LCService
        {
            get
            {
                return _lcService;
            }
        }

        private PrecioPrendaService _ppService = new PrecioPrendaService();

        public PrecioPrendaService PPService
        {
            get
            {
                return _ppService;
            }
        }

        [HttpGet(Name = "GetPrendas")]
        public ActionResult<IEnumerable<Prenda>> GetAll()
        {
            return Ok(Service.FindAll());
        }

        [HttpGet("{IdPrenda}")]
        public ActionResult<Prenda> GetById(int IdPrenda)
        {
            var m = Service.GetOne(IdPrenda);
            if (m == null)
            {
                return NotFound();
            }
            return Ok(m);
        }

        [HttpPost]
        public ActionResult<Prenda> Post(Prenda prenda)
        {
            var result = PrendaValidation.Parse(Service, prenda);
            if (result != null)
            {
                return BadRequest(result);
            }

            /*var tipoPrenda = TPService.GetOne(prenda.IdTipoPrenda);
            var marca = MService.GetOne(prenda.IdMarca);
            if (tipoPrenda == null || marca == null)
            {
                return BadRequest("La marca y/o el tipo de prenda ingresados son incorrectos");
            }*/
            //Probar a eliminar la asignación de tipo y marca

            /*prenda.TipoDePrenda = tipoPrenda;
            prenda.MarcaPrenda = marca;*/
            Service.Add(prenda);
            return CreatedAtAction(nameof(GetById), new { IdPrenda = prenda.IdPrenda }, prenda);


        }

        [HttpPut("{IdPrenda}")]
        public ActionResult<Prenda> Put(int IdPrenda, Prenda prenda)
        {
            if (IdPrenda != prenda.IdPrenda)
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

        [HttpDelete("{IdPrenda}")]
        public ActionResult<Prenda> Delete(int IdPrenda)
        {
            var prenda = Service.GetOne(IdPrenda);
            if (prenda == null)
            {
                return NotFound();
            }
            var result = PrendaValidation.ParseDelete(Service, LCService, prenda);
            if(result != null)
            {
                return BadRequest(result);
            }
            var precios = PPService.FindAll(IdPrenda);
            foreach (PrecioPrenda pp in precios)
            {
                PPService.Delete(pp);
            }
            Service.Delete(prenda);
            return NoContent();
        }
    }
}
