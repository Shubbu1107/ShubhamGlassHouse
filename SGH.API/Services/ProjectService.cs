using Microsoft.EntityFrameworkCore;
using SGH.API.Data;
using SGH.API.DTOs;
using SGH.API.Models;

namespace SGH.API.Services
{
    public class ProjectService : IProjectService
    {
        private readonly AppDbContext _context;

        public ProjectService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(CreateProjectDto dto)
        {
            var project = new ProjectItem
            {
                Title = dto.Title,
                Description = dto.Description,
                ImageUrl = dto.ImageUrl,
                Category = dto.Category
            };

            _context.Projects.Add(project);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ProjectResponseDto>> GetAllAsync()
        {
            return await _context.Projects
                .Where(p => p.IsActive)
                .OrderByDescending(p => p.CreatedAt)
                .Select(p => new ProjectResponseDto
                {
                    Id = p.Id,
                    Title = p.Title,
                    Description = p.Description,
                    ImageUrl = p.ImageUrl,
                    Category = p.Category
                })
                .ToListAsync();
        }
    }
}
