using cabe_API.Business;
using cabe_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace cabe_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IContactBusiness _contactBusiness;

        public ContactController(ILogger<ProductController> logger, IContactBusiness contactBusiness)
        {
            _logger = logger;
            _contactBusiness = contactBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var allProducts = _contactBusiness.FindAll();
            return Ok(allProducts);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _contactBusiness.FindById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Contact contact)
        {
            if (contact == null)
            {
                return BadRequest();
            }
            var createdContact = _contactBusiness.Create(contact);
            return CreatedAtAction(nameof(Get), new { id = createdContact.Id }, createdContact);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Contact contact)
        {
            if (contact == null)
            {
                return BadRequest();
            }
            var updatedContact = _contactBusiness.Update(contact);
            return Ok(updatedContact);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var contact = _contactBusiness.FindById(id);
            if (contact == null)
            {
                return NotFound();
            }
            _contactBusiness.Delete(id);
            return NoContent();
        }
    }
}
