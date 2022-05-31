using VibeDevTest.Models;

namespace VibeDevTest.Dto
{
    public class MaterialDto
    {
        public string Name { get; set; }
        public float PriceMultiplier { get; set; }

        public MaterialDto(Material m)
        {
            Name = m.Name;
            PriceMultiplier = m.PriceMultiplier;
        }
    }
}
