using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities.Data.AdminPortal
{
    public class Town
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Package type name is required")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "At least one connection is required")]
        public IEnumerable<Town>? Connections { get; set; }
    }
}
