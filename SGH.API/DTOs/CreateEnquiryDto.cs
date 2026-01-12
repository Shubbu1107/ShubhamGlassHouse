using System.ComponentModel.DataAnnotations;

namespace SGH.API.DTOs
{
    public class CreateEnquiryDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [Phone]
        public string Phone { get; set; } = null!;

        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string Service { get; set; } = null!;

        [Required]
        [MaxLength(500)]
        public string Message { get; set; } = null!;
    }
}
