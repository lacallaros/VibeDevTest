using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VibeDevTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartsStockController : ControllerBase
    {
        private readonly DataContext context;

        public PartsStockController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<PartsStock>>> Get()
        {
            return Ok(await context.PartsStocks.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PartsStock>> Get(int id)
        {
            var part = await context.PartsStocks.FindAsync(id);
            if (part == null)
            {
                return BadRequest("Part not found.");
            }
            
            return Ok(part);
        }

        [HttpPost]
        public async Task<ActionResult<List<PartsStock>>> AddPart(PartsStock part)
        {
            context.PartsStocks.Add(part);
            await context.SaveChangesAsync();

            return Ok(await context.PartsStocks.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<PartsStock>>> UpdatePart(PartsStock request)
        {
            var dbPart = await context.PartsStocks.FindAsync(request.Id);
            if (dbPart == null)
            {
                return BadRequest("Part not found.");
            }

            dbPart.Name = request.Name;
            dbPart.Price = request.Price;
            dbPart.Availability = request.Availability;
            dbPart.Quantity = request.Quantity;

            await context.SaveChangesAsync();

            return Ok(await context.PartsStocks.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<PartsStock>>> DeletePart(int id)
        {
            var dbPart = await context.PartsStocks.FindAsync(id);
            if (dbPart == null)
            {
                return BadRequest("Part not found.");
            }
            
            context.PartsStocks.Remove(dbPart);
            await context.SaveChangesAsync();

            return Ok(await context.PartsStocks.ToListAsync());
        }
    }
}
