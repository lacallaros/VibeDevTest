using VibeDevTest.Dto;
using VibeDevTest.Models;

namespace VibeDevTest.Interfaces
{
    public interface IPartsStockRepository
    {
        Task<List<PartsStockDto>> GetAllPartsAsync();
        Task<PartsStockDto> GetPartByIdAsync(int id);
        Task<PartsStock> AddPartAsync(PartsStock part);
        Task<List<PartsStock>> UpdatePartAsync(PartsStock part);
        Task<List<PartsStock>> DeletePartByIdAsync(int id);
    }
}
