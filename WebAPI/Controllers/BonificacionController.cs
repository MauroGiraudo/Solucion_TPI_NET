using Domain.Model.Compras;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class BonificacionController : Controller
    {
        private BonificacionService _service = new BonificacionService();
        public BonificacionService Service
        {
            get
            {
                return _service;
            }
        }

        [HttpGet(Name = "GetAllBonificaciones")]
        public ActionResult<IEnumerable<Bonificacion>> GetAll()
        {
            return Ok(Service.FindAll());
        }

        [HttpGet("{IdBonificacion}")]
        public ActionResult<Bonificacion> GetById(int IdBonificacion)
        {
            var bonif = Service.GetOne(IdBonificacion);
            if(bonif == null)
            {
                return NotFound();
            }
            return Ok(bonif);
        }

        /*[HttpPost]
        public ActionResult<Bonificacion> Post(Bonificacion bonificacion)
        {

        }*/
    }
}
