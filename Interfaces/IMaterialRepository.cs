using VibeDevTest.Dto;
using VibeDevTest.Models;

namespace VibeDevTest.Interfaces
{
    public interface IMaterialRepository
    {
        Task<List<MaterialDto>> GetAllMaterialsAsync();
        Task<MaterialDto> GetMaterialByIdAsync(int id);
        Task<Material> AddMaterialAsync(Material material);
        Task<List<Material>> UpdateMaterialAsync(Material material);
        Task<List<Material>> DeleteMaterialByIdAsync(int id);
    }
}
