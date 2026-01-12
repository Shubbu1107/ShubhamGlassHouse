using System;

namespace SGH.API.Models
{
    public class ProjectItem
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string Category { get; set; } = null!;
        // Example: Aluminium, Glass, Sliding Doors

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
