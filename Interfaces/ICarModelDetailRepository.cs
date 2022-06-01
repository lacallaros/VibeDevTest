using VibeDevTest.Models;

namespace VibeDevTest.Interfaces
{
    public interface ICarModelDetailRepository
    {
        Task<List<CarModelDetail>> GetAllCarModelDetailsAsync();
        Task<CarModel> GetCarModelDetailByIdAsync(int id);
        Task<CarModel> AddCarModelDetailAsync(CarModel carModel);
        Task<CarModel> UpdateCarModelDetailAsync(CarModel carModel);
        Task<CarModel> DeleteCarModelDetailAsync(int id);
    }
}
