using Microsoft.AspNetCore.Mvc;
using SGH.API.DTOs;
using SGH.API.Services;

namespace SGH.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceItemService _serviceItemService;

        public ServicesController(IServiceItemService serviceItemService)
        {
            _serviceItemService = serviceItemService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateServiceDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _serviceItemService.CreateAsync(dto);
            return Ok(new { message = "Service added successfully" });
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var services = await _serviceItemService.GetActiveAsync();
            return Ok(services);
        }
    }
}
