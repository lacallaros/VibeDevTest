using Microsoft.AspNetCore.Mvc;
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
    }
}
