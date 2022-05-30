using System.ComponentModel.DataAnnotations;
using VibeDevTest.Models;

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

        public PartsStockDto(PartsStock p)
        {
            Id = p.Id;
            Name = p.Name;
            Price = p.Price;
            Quantity = p.Quantity;
            Availability = p.Availability;
        }
    }
}
