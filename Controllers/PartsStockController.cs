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
        public async Task<ActionResult<PartsStock>> GetPartById(int id)
        {
            return Ok(await psRep.GetPartByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult<List<PartsStock>>> AddPart(PartsStock part)
        {
            return Ok(await psRep.AddPartAsync(part));
        }

        [HttpPut]
        public async Task<ActionResult<List<PartsStock>>> UpdatePart(PartsStock request)
        {
            return Ok(await psRep.UpdatePartAsync(request));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<PartsStock>>> DeletePart(int id)
        {
            return Ok(await psRep.DeletePartByIdAsync(id));
        }
    }
}
