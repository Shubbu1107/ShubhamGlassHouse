namespace SGH.API.Models
{
    public class Enquiry
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string? Email { get; set; }

        public string Service { get; set; } = null!;

        public string Message { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsContacted { get; set; } = false;
    }
}