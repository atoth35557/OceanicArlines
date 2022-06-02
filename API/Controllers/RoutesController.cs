using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using API.Entities.Data.Booking;

namespace API.Controllers
{
   // [Authorize]
    [ApiController]
    [Route("deliveries")]
    public class RoutesController : ControllerBase
    {
        [HttpPost]
        [Route("info")]
        public async Task<IActionResult> CalculateBooking([FromBody] Calculation calculation)
        {
            var random = new Random();
            
            return Ok(new CalculationResult { Price = random.NextDouble()*200,  Time = random.Next(0, 100) });
        }

        [HttpPost]
        [Route("confirm")]
        public async Task<IActionResult> ConfirmBooking([FromBody] BookingResult bookingResult)
        {
            var random = new Random();

            return Ok(new BookingResult { Price = random.NextDouble() * 200, IDs = new List<string> { "b7271266-ecbb-4658-9f8f-99e7d61f5727", "ffd1e502-6370-4709-bf09-a383cc7b30fc" } });
        }
    }


}
