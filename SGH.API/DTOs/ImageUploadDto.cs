using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SGH.API.DTOs
{
    public class ImageUploadDto
    {
        [Required]
        public IFormFile File { get; set; } = null!;
    }
}
