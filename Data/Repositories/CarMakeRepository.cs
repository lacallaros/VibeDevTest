using Microsoft.AspNetCore.JsonPatch;
using VibeDevTest.Dto;
using VibeDevTest.Interfaces;
using VibeDevTest.Models;

namespace VibeDevTest.Data.Repositories
{
    public class CarMakeRepository : ICarMakeRepository
    {
        private readonly DataContext context;

        public CarMakeRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<CarMake> AddCarMakeAsync(CarMakeDto carMake)
        {
            var newCarMake = new CarMake()
            {
                Name = carMake.Name,
                Country = carMake.Country,
            };

            context.CarMakes.Add(newCarMake);
            await context.SaveChangesAsync();

            return newCarMake;
        }

        public async Task<List<CarMake>> DeleteCarMakeAsync(int id)
        {
            var dbCarMake = await context.CarMakes.FindAsync(id);

            context.CarMakes.Remove(dbCarMake);
            await context.SaveChangesAsync();

            return await context.CarMakes.ToListAsync();
        }

        public async Task<List<CarMakeDto>> GetAllCarMakesAsync()
        {
            var carMakes = await context.CarMakes.ToListAsync();
            var carMakesDto = new List<CarMakeDto>();

            carMakes.ForEach(carMake =>
            {
                var carMakeDto = new CarMakeDto(carMake);
                carMakesDto.Add(carMakeDto);
            });
            
            return carMakesDto;
        }

        public async Task<CarMakeDto> GetCarMakeByIdAsync(int id)
        {
            CarMake carMake = await context.CarMakes.FindAsync(id);
            CarMakeDto carMakeDto = new CarMakeDto(carMake);

            return carMakeDto;
        }

        public async Task<List<CarMake>> UpdateCarMakeAsync(int id, JsonPatchDocument carMake)
        {
            var dbCarMake = await context.CarMakes.FindAsync(id);

            carMake.ApplyTo(dbCarMake);

            await context.SaveChangesAsync();

            return await context.CarMakes.ToListAsync();
        }
    }
}
