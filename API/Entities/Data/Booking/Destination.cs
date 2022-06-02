using System.ComponentModel.DataAnnotations;

namespace API.Entities.Data.Booking
{
    public class Destination
    {
        [Required(ErrorMessage = "From Destination is required")]
        public string? From { get; set; }
        [Required(ErrorMessage = "To Destination is required")]
        public string? To { get; set; }

    }
}
