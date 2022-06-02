using System.ComponentModel.DataAnnotations;

namespace API.Entities.Data.Booking
{
    public class BookingResult
    {

        public double? Price { get; set; }
        public IEnumerable<string>? IDs { get; set; }

    }
}
