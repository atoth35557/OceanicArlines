using API.Entities;
using API.Entities.Data.AdminPortal;
using API.Entities.Data.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Authorize(Roles = UserRoles.Employee)]
    [ApiController]
    [Route("[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly ApplicationContext context;

        public InvoiceController(ApplicationContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetInvoices()
        {
            return Ok(await context.Invoices.ToListAsync());
        }
    }
}
