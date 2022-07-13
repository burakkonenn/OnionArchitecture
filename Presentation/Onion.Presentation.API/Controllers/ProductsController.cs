using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion.Application.Abstraction;

namespace Onion.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductService _IProductService;
        public ProductsController(IProductService productService)
        {
            _IProductService = productService;
        }

        [HttpGet]
        public IActionResult GetProduct()
        {

            return Ok();
        }
    }
}
