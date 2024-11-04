using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/Cliente/{IdUsu}/[controller]")]
    public class CompraController : Controller
    {
        private CompraService _service = new CompraService();
        public CompraService Service
        {
            get
            {
                return _service;
            }
        }
        [HttpGet()]
    }
}
