using System.ComponentModel.DataAnnotations;
using VibeDevTest.Models;

namespace VibeDevTest.Dto
{
    public class CarModelDetailDto
    {
        [Required]
        [StringLength(40)]
        public string Description { get; set; }

        public CarModelDetailDto(CarModelDetail carModelDetail)
        {
            Description = carModelDetail.Description;
        }
    }
}
