using VibeDevTest.Dto;
using VibeDevTest.Interfaces;
using VibeDevTest.Models;

namespace VibeDevTest.Data.Repositories
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly DataContext context;

        public MaterialRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<Material> AddMaterialAsync(Material material)
        {
            context.Materials.Add(material);
            await context.SaveChangesAsync();

            return material;
        }

        public async Task<List<Material>> DeleteMaterialByIdAsync(int id)
        {
            var dbMat = await context.Materials.FindAsync(id);

            context.Materials.Remove(dbMat);
            await context.SaveChangesAsync();

            return await context.Materials.ToListAsync();
        }

        public async Task<List<MaterialDto>> GetAllMaterialsAsync()
        {
            var materials = await context.Materials.ToListAsync();
            var materialsDto = new List<MaterialDto>();

            materials.ForEach(material =>
            {
                var materialDto = new MaterialDto(material);
                materialsDto.Add(materialDto);
            });

            return materialsDto;
        }

        public async Task<MaterialDto> GetMaterialByIdAsync(int id)
        {
            Material m = await context.Materials.FindAsync(id);
            MaterialDto materialDto = new MaterialDto(m);

            return materialDto;
        }

        public async Task<List<Material>> UpdateMaterialAsync(Material request)
        {
            var dbMat = await context.Materials.FindAsync(request.Id);

            dbMat.Name = request.Name;
            dbMat.PriceMultiplier = request.PriceMultiplier;
            dbMat.PartsStock = request.PartsStock;

            await context.SaveChangesAsync();

            return await context.Materials.ToListAsync();
        }
    }
}
