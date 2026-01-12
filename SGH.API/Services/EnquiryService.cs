using SGH.API.Data;
using SGH.API.DTOs;
using SGH.API.Models;
using Microsoft.EntityFrameworkCore;

namespace SGH.API.Services
{
    public class EnquiryService : IEnquiryService
    {
        private readonly AppDbContext _context;

        public EnquiryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(CreateEnquiryDto dto)
        {
            var enquiry = new Enquiry
            {
                Name = dto.Name,
                Phone = dto.Phone,
                Email = dto.Email,
                Service = dto.Service,
                Message = dto.Message
            };

            _context.Enquiries.Add(enquiry);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Enquiry>> GetAllAsync()
        {
            return await _context.Enquiries
                .OrderByDescending(e => e.CreatedAt)
                .ToListAsync();
        }
    }
}
