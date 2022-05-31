namespace VibeDevTest.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float PriceMultiplier { get; set; }
        public PartsStock PartsStock { get; set; }
    }
}
