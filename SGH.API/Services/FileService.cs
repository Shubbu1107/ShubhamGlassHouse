using Microsoft.AspNetCore.Http;

namespace SGH.API.Services
{
    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment _env;

        public FileService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public async Task<string> SaveImageAsync(IFormFile file, string folder)
        {
            var allowedTypes = new[] { "image/jpeg", "image/png", "image/webp" };

            if (!allowedTypes.Contains(file.ContentType))
                throw new Exception("Invalid file type");

            if (file.Length > 5 * 1024 * 1024)
                throw new Exception("File too large (max 5MB)");

            var uploadsPath = Path.Combine(_env.WebRootPath, "uploads", folder);

            if (!Directory.Exists(uploadsPath))
                Directory.CreateDirectory(uploadsPath);

            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
            var filePath = Path.Combine(uploadsPath, fileName);

            using var stream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(stream);

            return $"/uploads/{folder}/{fileName}";
        }
    }
}
