using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetDishes([FromQuery]int count)
        {
            
            string[] dishes = { "Makaronia", "Kota Rizi", "Bithkoti", "Kotopsaro" };
            if (!dishes.Any())
                return NotFound();
            return Ok(dishes.Take(count));
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteRecipes(string id)
        {
            bool bTh = false;
            if (bTh)
            {
                return BadRequest();
            }
            return NoContent();
        }
    }
}
 