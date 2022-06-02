using System.ComponentModel.DataAnnotations;

namespace API.Entities.Data.Booking
{
    public class Customer
    {
        [Required(ErrorMessage = "Firstname is required")]
        public string? Firstname { get; set; }
        [Required(ErrorMessage = "Lastname is required")]
        public string? Lastname { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string MyProperty { get; set; }
    }
}
