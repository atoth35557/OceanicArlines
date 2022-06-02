using API.Entities.Data.Booking;

namespace API.Repositories.Implementations
{
    public interface IRouteCalculationProvider
    {
        public Task<CalculationResult> CalculateRoute(Calculation calculation);
        public Task<BookingResult> BookShipment(Booking booking);
    }
}
