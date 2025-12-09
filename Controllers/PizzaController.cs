using BlazingPizza.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Controllers
{
    [Route("api/pizzas/")]
    [ApiController]
    public class PizzaController(PizzaDbContext context) : ControllerBase
    {
       private PizzaDbContext _context = context;

        [HttpGet("getpizzas")]
        public async Task<ActionResult<List<PizzaSpecial>>> GetPizzasList() {

         
            
            return Ok(await _context.PizzasDb.ToListAsync());
        }

    }
}
