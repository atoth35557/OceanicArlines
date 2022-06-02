using System.ComponentModel.DataAnnotations;

namespace API.Entities.Data.Booking
{
    public class Package
    {
        [Required(ErrorMessage = "Package weigth is required")]
        public string? weight { get; set; }
        [Required(ErrorMessage = "Package height is required")]
        public string? height { get; set; }
        [Required(ErrorMessage = "Package wifth is required")]
        public string? width { get; set; }
        [Required(ErrorMessage = "Package depth is required")]
        public string? depth { get; set; }
        [Required(ErrorMessage = "Package type is required")]
        public string? type { get; set; }

    }
}
