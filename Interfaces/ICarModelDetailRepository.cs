using Microsoft.AspNetCore.JsonPatch;
using VibeDevTest.Dto;
using VibeDevTest.Models;

namespace VibeDevTest.Interfaces
{
    public interface ICarModelDetailRepository
    {
        Task<List<CarModelDetailDto>> GetAllCarModelDetailsAsync();
        Task<CarModelDetailDto> GetCarModelDetailByIdAsync(int id);
        Task<CarModelDetail> AddCarModelDetailAsync(CarModelDetailDto carModelDetail);
        Task<List<CarModelDetail>> UpdateCarModelDetailAsync(int id, JsonPatchDocument carModelDetail);
        Task<List<CarModelDetail>> DeleteCarModelDetailAsync(int id);
    }
}
