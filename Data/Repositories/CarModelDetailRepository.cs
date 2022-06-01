using VibeDevTest.Interfaces;
using VibeDevTest.Models;

namespace VibeDevTest.Data.Repositories
{
    public class CarModelDetailRepository : ICarModelDetailRepository
    {
        private readonly DataContext context;

        public CarModelDetailRepository(DataContext context)
        {
            this.context = context;
        }

        public Task<CarModel> AddCarModelDetailAsync(CarModel carModel)
        {
            throw new NotImplementedException();
        }

        public Task<CarModel> DeleteCarModelDetailAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CarModelDetail>> GetAllCarModelDetailsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CarModel> GetCarModelDetailByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CarModel> UpdateCarModelDetailAsync(CarModel carModel)
        {
            throw new NotImplementedException();
        }
    }
}
