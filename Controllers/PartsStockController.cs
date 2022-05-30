using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VibeDevTest.Dto;
using VibeDevTest.Interfaces;
using VibeDevTest.Models;

namespace VibeDevTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartsStockController : ControllerBase
    {
        private readonly IPartsStockRepository psRep;

        public PartsStockController(IPartsStockRepository psRep)
        {
            this.psRep = psRep;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllParts()
        {
            return Ok(await psRep.GetAllPartsAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPartById(int id)
        {
            return Ok(await psRep.GetPartByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddPart(PartsStock part)
        {
            return Ok(await psRep.AddPartAsync(part));
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePart(PartsStock request)
        {
            return Ok(await psRep.UpdatePartAsync(request));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePart(int id)
        {
            return Ok(await psRep.DeletePartByIdAsync(id));
        }
    }
}
