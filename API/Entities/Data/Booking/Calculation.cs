using System.ComponentModel.DataAnnotations;

namespace API.Entities.Data.Booking
{
    public class Calculation
    {
        public Destination? Destination { get; set; }
        public Package? Package { get; set; }

    }
}
