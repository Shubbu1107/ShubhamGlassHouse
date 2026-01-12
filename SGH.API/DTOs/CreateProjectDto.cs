using System.ComponentModel.DataAnnotations;

namespace SGH.API.DTOs
{
    public class CreateProjectDto
    {
        [Required]
        [MaxLength(150)]
        public string Title { get; set; } = null!;

        [MaxLength(500)]
        public string? Description { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public string Category { get; set; } = null!;
    }
}
