using API.Entities;
using API.Entities.Data.AdminPortal;
using API.Entities.Data.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    [ApiController]
    [Route("[controller]")]
    public class TownsController : ControllerBase
    {
        private readonly ApplicationContext context;

        public TownsController(ApplicationContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetTowns()
        {
            return Ok(await context.Towns.ToListAsync());
        }

        [HttpPost]
        public IActionResult AddTown([FromBody] Town town)
        {
            if(town == null)
            {
                return BadRequest("Invalid town");
            }
            town.Id = Guid.NewGuid();
            context.Towns.Add(town);
            return NoContent();
        }

        [HttpPut]
        public IActionResult PutTown([FromBody] Town town)
        {
            if (town == null)
            {
                return NotFound();
            }
            context.Towns.Update(town);
            return NoContent();
        }

        [HttpPut]
        public IActionResult DeleteTown([FromBody] Town town)
        {
            if (town == null)
            {
                return NotFound();
            }
            context.Towns.Remove(town);
            return NoContent();
        }
    }
}
