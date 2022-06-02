using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using VibeDevTest.Dto;
using VibeDevTest.Interfaces;

namespace VibeDevTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarMakeController : Controller
    {
        private ICarMakeRepository makeRep;

        public CarMakeController(ICarMakeRepository makeRep)
        {
            this.makeRep = makeRep;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCarMakes()
        {
            return Ok(await makeRep.GetAllCarMakesAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarMakeById(int id)
        {
            return Ok(await makeRep.GetCarMakeByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCarMake(CarMakeDto carMake)
        {
            return Ok(await makeRep.AddCarMakeAsync(carMake));
        }

        [HttpPatch]
        public async Task<IActionResult> UpdateCarMake(int id, JsonPatchDocument carMake)
        {
            return Ok(await makeRep.UpdateCarMakeAsync(id, carMake));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarMake(int id)
        {
            return Ok(await makeRep.DeleteCarMakeAsync(id));
        }
    }
}
