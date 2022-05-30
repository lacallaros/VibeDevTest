using System.ComponentModel.DataAnnotations;
using VibeDevTest.Models;

namespace VibeDevTest.Dto
{
    public class PartsStockDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required] 
        public string Price { get; set; }
        public bool Availability { get; set; }

        public PartsStockDto(PartsStock p)
        {
            Name = p.Name;
            Price = p.Price;
            Availability = p.Availability;
        }
    }
}
