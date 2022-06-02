using Microsoft.AspNetCore.JsonPatch;
using VibeDevTest.Dto;
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

        public async Task<CarModelDetail> AddCarModelDetailAsync(CarModelDetailDto carModelDetail)
        {
            var newCarModelDetail = new CarModelDetail()
            {
                Description = carModelDetail.Description,
            };

            context.CarModelDetails.Add(newCarModelDetail);
            await context.SaveChangesAsync();

            return newCarModelDetail;
        }

        public async Task<List<CarModelDetail>> DeleteCarModelDetailAsync(int id)
        {
            var dbCarModelDetail = await context.CarModelDetails.FindAsync(id);

            context.CarModelDetails.Remove(dbCarModelDetail);
            await context.SaveChangesAsync();

            return await context.CarModelDetails.ToListAsync();
        }

        public async Task<List<CarModelDetailDto>> GetAllCarModelDetailsAsync()
        {
            var carModelDetails = await context.CarModelDetails.ToListAsync();
            var carModelDetailsDto = new List<CarModelDetailDto>();

            carModelDetails.ForEach(carModelDetail =>
            {
                var carModelDetailDto = new CarModelDetailDto(carModelDetail);
                carModelDetailsDto.Add(carModelDetailDto);
            });

            return carModelDetailsDto;
        }

        public async Task<CarModelDetailDto> GetCarModelDetailByIdAsync(int id)
        {
            CarModelDetail carModelDetail = await context.CarModelDetails.FindAsync(id);
            CarModelDetailDto carModelDetailDto = new CarModelDetailDto(carModelDetail);

            return carModelDetailDto;
        }

        public async Task<List<CarModelDetail>> UpdateCarModelDetailAsync(int id, JsonPatchDocument carModelDetail)
        {
            var dbCarModelDetail = await context.CarModelDetails.FindAsync(id);

            carModelDetail.ApplyTo(dbCarModelDetail);

            await context.SaveChangesAsync();

            return await context.CarModelDetails.ToListAsync();
        }
    }
}
