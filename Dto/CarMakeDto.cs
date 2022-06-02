using System.ComponentModel.DataAnnotations;
using VibeDevTest.Models;

namespace VibeDevTest.Dto
{
    public class CarMakeDto
    {
        [Required]
        public string Name { get; set; }
        public string Country { get; set; }

        public CarMakeDto(CarMake carMake)
        {
            Name = carMake.Name;
            Country = carMake.Country;
        }
    }
}
