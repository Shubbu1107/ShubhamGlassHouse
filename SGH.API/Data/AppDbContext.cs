using Microsoft.EntityFrameworkCore;
using SGH.API.Models;
using System.Collections.Generic;

namespace SGH.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Enquiry> Enquiries { get; set; }
        public DbSet<ServiceItem> Services { get; set; }
        public DbSet<ProjectItem> Projects { get; set; }

    }
}
