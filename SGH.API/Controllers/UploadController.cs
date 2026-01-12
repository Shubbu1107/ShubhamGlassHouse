using Microsoft.AspNetCore.Mvc;
using SGH.API.Services;

namespace SGH.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UploadController : ControllerBase
    {
        private readonly IFileService _fileService;

        public UploadController(IFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpPost("{folder}")]
        public async Task<IActionResult> Upload(string folder, IFormFile file)
        {
            if (file == null)
                return BadRequest("No file uploaded");

            try
            {
                var path = await _fileService.SaveImageAsync(file, folder);
                return Ok(new { imageUrl = path });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
