using API.Entities.Data.Booking;

namespace API.Repositories.Implementations
{
    public class RouteCalculationProvider : IRouteCalculationProvider
    {
        public Task<BookingResult> BookShipment(Booking booking)
        {
            var random = new Random();
            return Task.FromResult(new BookingResult { Price = random.NextDouble() * 200, IDs = new List<string> { "b7271266-ecbb-4658-9f8f-99e7d61f5727", "ffd1e502-6370-4709-bf09-a383cc7b30fc" } });
        }

        public Task<CalculationResult> CalculateRoute(Calculation calculation)
        {
            var random = new Random();
            return Task.FromResult(new CalculationResult { Price = random.NextDouble() * 200, Time = random.Next(0, 100) });
        }
    }
}
