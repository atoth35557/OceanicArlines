using API.Entities;
using API.Entities.Data.AdminPortal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PackageTypesController : ControllerBase
    {
        private readonly ApplicationContext context;

        public PackageTypesController(ApplicationContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetTypes()
        {
            return Ok(await context.PackageTypes.ToListAsync());
        }

        [HttpPost]
        public IActionResult AddType([FromBody] PackageType type)
        {
            if (type == null)
            {
                return BadRequest("Invalid town");
            }
            type.Id = Guid.NewGuid();
            context.PackageTypes.Add(type);
            if (context.SaveChanges() < 1)
            {
                return StatusCode(500);
            }
            return NoContent();
        }

        [HttpPut]
        public IActionResult PutTown([FromBody] PackageType packageType)
        {
            if (packageType == null)
            {
                return NotFound();
            }
            context.PackageTypes.Update(packageType);
            if (context.SaveChanges() < 1)
            {
                return StatusCode(500);
            }
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteTown([FromBody] PackageType packageType)
        {
            if (packageType == null)
            {
                return NotFound();
            }
            context.PackageTypes.Remove(packageType);
            if (context.SaveChanges() < 1)
            {
                return StatusCode(500);
            }
            return NoContent();
        }
    }
}
