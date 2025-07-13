using cabe_API.Business;
using cabe_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace cabe_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductBusiness _personBusiness;

        public ProductController(ILogger<ProductController> logger, IProductBusiness productBusiness)
        {
            _logger = logger;
            _personBusiness = productBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var allProducts = _personBusiness.FindAll();
            return Ok(allProducts);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _personBusiness.FindById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest();
            }
            var createdProduct = _personBusiness.Create(product);
            return CreatedAtAction(nameof(Get), new { id = createdProduct.Id }, createdProduct);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest();
            }
            var updatedProduct = _personBusiness.Update(product);
            return Ok(updatedProduct);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _personBusiness.FindById(id);
            if (product == null)
            {
                return NotFound();
            }
            _personBusiness.Delete(id);
            return NoContent();
        }
    }
}
