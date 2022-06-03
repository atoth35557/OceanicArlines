using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities.Data.AdminPortal
{
    public class Town
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Package type name is required")]
        public string? Name { get; set; }
        public IEnumerable<Town>? Connections { get; set; }
    }
}
