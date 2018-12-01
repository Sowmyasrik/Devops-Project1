using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }

        [Required]
        public string Name { get; set; }

        // Some Comment to trigger a Build
        // Some more changes...
    }
}