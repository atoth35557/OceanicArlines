using System.ComponentModel.DataAnnotations;

namespace API.Entities.Data.Booking
{
    public class Package
    {
        [Required(ErrorMessage = "Package weigth is required")]
        public double? weight { get; set; }
        [Required(ErrorMessage = "Package height is required")]
        public double? height { get; set; }
        [Required(ErrorMessage = "Package wifth is required")]
        public double? width { get; set; }
        [Required(ErrorMessage = "Package depth is required")]
        public double? depth { get; set; }
        [Required(ErrorMessage = "Package type is required")]
        public List<string>? types { get; set; }

    }
}
