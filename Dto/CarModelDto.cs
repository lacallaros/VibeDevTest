using System.ComponentModel.DataAnnotations;
using VibeDevTest.Models;

namespace VibeDevTest.Dto
{
    public class CarModelDto
    {
        [Required]
        public string Name { get; set; }
        public string Chassis { get; set; }
        public int MakeId { get; set; }

        public CarModelDto(CarModel carModel)
        {
            Name = carModel.Name;
            Chassis = carModel.Chassis;
            MakeId = carModel.MakeId;
        }
    }
}
