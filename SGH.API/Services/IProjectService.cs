using SGH.API.DTOs;

namespace SGH.API.Services
{
    public interface IProjectService
    {
        Task CreateAsync(CreateProjectDto dto);
        Task<List<ProjectResponseDto>> GetAllAsync();
    }
}
