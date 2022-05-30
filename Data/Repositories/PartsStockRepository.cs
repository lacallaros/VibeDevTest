using VibeDevTest.Dto;
using VibeDevTest.Interfaces;
using VibeDevTest.Models;

namespace VibeDevTest.Data.Repositories
{
    public class PartsStockRepository : IPartsStockRepository
    {
        private readonly DataContext context;

        public PartsStockRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<PartsStock> AddPartAsync(PartsStock part)
        {
            context.PartsStocks.Add(part);
            await context.SaveChangesAsync();

            return part;
        }

        public async Task<List<PartsStock>> DeletePartByIdAsync(int id)
        {
            var dbPart = await context.PartsStocks.FindAsync(id);

            context.PartsStocks.Remove(dbPart);
            await context.SaveChangesAsync();

            return await context.PartsStocks.ToListAsync();
        }

        public async Task<List<PartsStockDto>> GetAllPartsAsync()
        {
            var parts = await context.PartsStocks.ToListAsync();
            var partsDto = new List<PartsStockDto>();

            parts.ForEach(part =>
            {
                var partsStockDto = new PartsStockDto
                {
                    Id = part.Id,
                    Name = part.Name,
                    Price = part.Price,
                    Quantity = part.Quantity,
                    Availability = part.Availability
                };
                partsDto.Add(partsStockDto);
            });

            return partsDto;
        }

        public async Task<PartsStockDto> GetPartByIdAsync(int id)
        {
            var part = await context.PartsStocks.FindAsync(id);
            var partDto = new PartsStockDto
            {
                Id = part.Id,
                Name = part.Name,
                Price = part.Price,
                Quantity = part.Quantity,
                Availability = part.Availability
            };
            return partDto;
        }

        public async Task<List<PartsStock>> UpdatePartAsync(PartsStock request)
        {
            var dbPart = await context.PartsStocks.FindAsync(request.Id);

            dbPart.Name = request.Name;
            dbPart.Price = request.Price;
            dbPart.Availability = request.Availability;
            dbPart.Quantity = request.Quantity;

            await context.SaveChangesAsync();

            return await context.PartsStocks.ToListAsync();
        }
    }
}
