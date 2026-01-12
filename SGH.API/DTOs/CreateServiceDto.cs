using System.ComponentModel.DataAnnotations;

namespace SGH.API.DTOs
{
    public class CreateServiceDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = null!;

        public string? ImageUrl { get; set; }
    }
}
