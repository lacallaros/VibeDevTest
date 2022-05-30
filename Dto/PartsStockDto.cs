using System.ComponentModel.DataAnnotations;

namespace VibeDevTest.Dto
{
    public class PartsStockDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required] 
        public string Price { get; set; }
        public int Quantity { get; set; }
        public bool Availability { get; set; }
    }
}
