using Microsoft.EntityFrameworkCore;
using SGH.API.Data;
using SGH.API.DTOs;
using SGH.API.Models;

namespace SGH.API.Services
{
    public class ServiceItemService : IServiceItemService
    {
        private readonly AppDbContext _context;

        public ServiceItemService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(CreateServiceDto dto)
        {
            var service = new ServiceItem
            {
                Name = dto.Name,
                Description = dto.Description,
                ImageUrl = dto.ImageUrl
            };

            _context.Services.Add(service);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ServiceResponseDto>> GetActiveAsync()
        {
            return await _context.Services
                .Where(s => s.IsActive)
                .OrderBy(s => s.Name)
                .Select(s => new ServiceResponseDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    ImageUrl = s.ImageUrl
                })
                .ToListAsync();
        }
    }
}
