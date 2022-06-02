using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using VibeDevTest.Dto;
using VibeDevTest.Interfaces;

namespace VibeDevTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarModelController : Controller
    {
        private ICarModelRepository modRep;

        public CarModelController(ICarModelRepository modRep)
        {
            this.modRep = modRep;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCarModels()
        {
            return Ok(await modRep.GetAllCarModelsAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarModelById(int id)
        {
            return Ok(await modRep.GetCarModelByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCarModel(CarModelDto carModel)
        {
            return Ok(await modRep.AddCarModelAsync(carModel));
        }

        [HttpPatch]
        public async Task<IActionResult> UpdateCarModel(int id, JsonPatchDocument carModel)
        {
            return Ok(await modRep.UpdateCarModelAsync(id, carModel));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarModel (int id)
        {
            return Ok(await modRep.DeleteCarModelAsync(id));
        }
    }
}
