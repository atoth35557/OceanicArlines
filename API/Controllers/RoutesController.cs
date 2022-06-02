using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using API.Entities.Data.Booking;
using API.Repositories.Implementations;

namespace API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("deliveries")]
    public class RoutesController : ControllerBase
    {
        private readonly IRouteCalculationProvider calculationProvider;

        public RoutesController(IRouteCalculationProvider calculationProvider)
        {
            this.calculationProvider = calculationProvider;
        }
        [HttpPost]
        [Route("info")]
        public async Task<IActionResult> CalculateBooking([FromBody] Calculation calculation)
        {

            var result = await calculationProvider.CalculateRoute(calculation);
            return Ok(result);
        }

        [HttpPost]
        [Route("confirm")]
        public async Task<IActionResult> ConfirmBooking([FromBody] Booking booking)
        {
            var result = await calculationProvider.BookShipment(booking);
            return Ok(result);
        }
    }


}
