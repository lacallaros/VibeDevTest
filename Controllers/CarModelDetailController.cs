using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using VibeDevTest.Dto;
using VibeDevTest.Interfaces;

namespace VibeDevTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarModelDetailController : Controller
    {
        private ICarModelDetailRepository detRep;

        public CarModelDetailController(ICarModelDetailRepository detRep)
        {
            this.detRep = detRep;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCarModelDetails()
        {
            return Ok(await detRep.GetAllCarModelDetailsAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarModelById(int id)
        {
            return Ok(await detRep.GetCarModelDetailByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCarModel(CarModelDetailDto carModelDetail)
        {
            return Ok(await detRep.AddCarModelDetailAsync(carModelDetail));
        }

        [HttpPatch]
        public async Task<IActionResult> UpdateCarModel(int id, JsonPatchDocument carModelDetail)
        {
            return Ok(await detRep.UpdateCarModelDetailAsync(id, carModelDetail));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarModel(int id)
        {
            return Ok(await detRep.DeleteCarModelDetailAsync(id));
        }
    }
}
