using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BobsShop.Inventory.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        //TODO: move this into a model (POCO)
        private static readonly string[] Products = new[]
        {
            "Beer", "Food", "Baguettes"  
        };

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<string[]> Get()
        {
            return new JsonResult(Products);
        }
    }
}