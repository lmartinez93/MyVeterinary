using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MyVeterinary.Web.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile imageFile);
    }
}