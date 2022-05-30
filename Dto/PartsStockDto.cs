using System.ComponentModel.DataAnnotations;

namespace VibeDevTest.Dto
{
    public class PartsStockDto
    {        
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required] 
        public string Price { get; set; }
        public int Quantity { get; set; }
    }
}
