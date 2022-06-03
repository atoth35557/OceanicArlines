using System.ComponentModel.DataAnnotations;

namespace API.Entities.Data.AdminPortal
{
    public class PackageType
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Wight is required")]
        public decimal Weight { get; set; }
        [Required(ErrorMessage = "Widht is required")]
        public decimal Widht { get; set; }
        [Required(ErrorMessage = "Hight is required")]
        public decimal Hight { get; set; }
        [Required(ErrorMessage = "Deph is required")]
        public decimal Deph { get; set; }
    }
}
