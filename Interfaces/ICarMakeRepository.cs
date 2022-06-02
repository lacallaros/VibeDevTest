using Microsoft.AspNetCore.JsonPatch;
using VibeDevTest.Dto;
using VibeDevTest.Models;

namespace VibeDevTest.Interfaces
{
    public interface ICarMakeRepository
    {
        Task<List<CarMakeDto>> GetAllCarMakesAsync();
        Task<CarMakeDto> GetCarMakeByIdAsync(int id);
        Task<CarMake> AddCarMakeAsync(CarMakeDto carMake);
        Task<List<CarMake>> UpdateCarMakeAsync(int id, JsonPatchDocument carMake);
        Task<List<CarMake>> DeleteCarMakeAsync(int id);
    }
}
