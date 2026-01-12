namespace SGH.API.DTOs
{
    public class ProjectResponseDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string Category { get; set; } = null!;
    }
}
