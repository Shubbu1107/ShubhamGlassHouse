using SGH.API.DTOs;

namespace SGH.API.Services
{
    public interface IServiceItemService
    {
        Task CreateAsync(CreateServiceDto dto);
        Task<List<ServiceResponseDto>> GetActiveAsync();
    }
}
