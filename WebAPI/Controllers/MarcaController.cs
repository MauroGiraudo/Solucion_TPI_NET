using Domain.Model.Prendas;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Validations;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarcaController : Controller
    {
        private MarcaService _service = new MarcaService();

        public MarcaService Service
        {
            get
            {
                return _service;
            }
        }

        [HttpGet(Name = "GetMarcas")]
        public ActionResult<IEnumerable<Marca>> GetAll()
        {
            return Ok(Service.FindAll());
        }

        [HttpGet("{Id}")]
        public ActionResult<Marca> GetById(int Id)
        {
            var m = Service.GetOne(Id);
            if (m == null)
            {
                return NotFound();
            }
            return Ok(m);
        }

        [HttpPost]
        public ActionResult<Marca> Post(Marca marca)
        {
            var m = Service.GetOne(marca.IdMarca);
            if(m == null)
            {
                var result = MarcaValidation.Parse(Service, marca);
                if(result == null)
                {
                    Service.Add(marca);
                    return CreatedAtAction(nameof(GetById), new { Id = marca.IdMarca }, marca);
                }
                return BadRequest(result);
            }
            return BadRequest();
        }

        [HttpPut("{Id}")]
        public ActionResult<Marca> Put(int Id, Marca marca)
        {
            if (Id != marca.IdMarca)
            {
                return BadRequest();
            }
            var result = MarcaValidation.Parse(Service, marca);
            if(result != null)
            {
                return BadRequest(result);
            }
            Service.Update(marca);
            return NoContent();
        }

        [HttpDelete("{Id}")]
        public ActionResult<Marca> Delete(int Id)
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
