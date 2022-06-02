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

        public async Task<CarModel> AddCarModelAsync(CarModelDto carModel)
        {
            var newCarModel = new CarModel()
            {
                Name = carModel.Name,
                Chassis = carModel.Chassis,
                MakeId = carModel.MakeId
            };

            context.CarModels.Add(newCarModel);
            await context.SaveChangesAsync();

            return newCarModel;
        }

        public async Task<List<CarModel>> DeleteCarModelAsync(int id)
        {
            var dbCarModel = await context.CarModels.FindAsync(id);

            context.CarModels.Remove(dbCarModel);
            await context.SaveChangesAsync();

            return await context.CarModels.ToListAsync();
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

        public async Task<CarModelDto> GetCarModelByIdAsync(int id)
        {
            CarModel carModel = await context.CarModels.FindAsync(id);
            CarModelDto carModelDto = new CarModelDto(carModel);

            return carModelDto;
        }

        public async Task<List<CarModel>> UpdateCarModelAsync(int id, JsonPatchDocument carModel)
        {
            var dbCarModel = await context.CarModels.FindAsync(id);

            carModel.ApplyTo(dbCarModel);

            await context.SaveChangesAsync();

            return await context.CarModels.ToListAsync();
        }
    }
}
