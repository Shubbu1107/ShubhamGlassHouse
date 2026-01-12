using Microsoft.AspNetCore.Mvc;
using SGH.API.DTOs;
using SGH.API.Services;

namespace SGH.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnquiriesController : ControllerBase
    {
        private readonly IEnquiryService _enquiryService;

        public EnquiriesController(IEnquiryService enquiryService)
        {
            _enquiryService = enquiryService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateEnquiryDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _enquiryService.CreateAsync(dto);

            return Ok(new { message = "Enquiry submitted successfully" });
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var enquiries = await _enquiryService.GetAllAsync();
            return Ok(enquiries);
        }
    }
}
