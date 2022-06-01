using VibeDevTest.Models;

namespace VibeDevTest.Dto
{
    public class CarModelDetailDto
    {
        public string Description { get; set; }

        public CarModelDetailDto(CarModelDetail carModelDetail)
        {
            Description = carModelDetail.Description;
        }
    }
}
