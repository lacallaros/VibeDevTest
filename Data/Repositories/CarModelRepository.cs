using Microsoft.AspNetCore.JsonPatch;
using VibeDevTest.Dto;
using VibeDevTest.Interfaces;
using VibeDevTest.Models;

namespace VibeDevTest.Data.Repositories
{
    public class CarModelRepository : ICarModelRepository
    {
        private readonly DataContext context;

        public CarModelRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<CarModel> AddCarModelAsync(CarModel carModel)
        {
            var newCarModel = new CarModel()
            {
                Name = carModel.Name,
                Chassis = carModel.Chassis,
            };

            context.CarModels.Add(newCarModel);
            await context.SaveChangesAsync();

            return newCarModel;
        }

        public Task<List<CarModel>> DeleteCarModelAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CarModelDto>> GetAllCarModelsAsync()
        {
            var carModels = await context.CarModels.ToListAsync();
            var carModelsDto = new List<CarModelDto>();

            carModels.ForEach(carModel =>
            {
                var carModelDto = new CarModelDto(carModel);
                carModelsDto.Add(carModelDto);
            });

            return carModelsDto;
        }

        public Task<CarModelDto> GetCarModelByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CarModel>> UpdateCarModelAsync(int id, JsonPatchDocument carModel)
        {
            throw new NotImplementedException();
        }
    }
}
