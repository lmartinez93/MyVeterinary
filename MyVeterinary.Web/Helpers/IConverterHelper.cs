using MyVeterinary.Web.Data.Entities;
using MyVeterinary.Web.Models;
using System.Threading.Tasks;

namespace MyVeterinary.Web.Helpers
{
    public interface IConverterHelper
    {
        Task<Pet> ToPetAsync(PetViewModel model, string path);

        PetViewModel ToPetViewModel(Pet pet);
    }
}