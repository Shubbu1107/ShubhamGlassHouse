namespace SGH.API.Services
{
    public interface IFileService
    {
        Task<string> SaveImageAsync(IFormFile file, string folder);
    }
}
