using Microsoft.AspNetCore.JsonPatch;
using VibeDevTest.Dto;
using VibeDevTest.Models;

namespace VibeDevTest.Interfaces
{
    public interface ICarModelRepository
    {
        Task<List<CarModelDto>> GetAllCarModelsAsync();
        Task<CarModelDto> GetCarModelByIdAsync(int id);
        Task<CarModel> AddCarModelAsync(CarModelDto carModel);
        Task<List<CarModel>> UpdateCarModelAsync(int id, JsonPatchDocument carModel);
        Task<List<CarModel>> DeleteCarModelAsync(int id);
    }
}
