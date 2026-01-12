using SGH.API.DTOs;
using SGH.API.Models;

namespace SGH.API.Services
{
    public interface IEnquiryService
    {
        Task CreateAsync(CreateEnquiryDto dto);
        Task<List<Enquiry>> GetAllAsync();
    }
}
