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
        public string[] GetDishes()
        {
            string[] dishes = { "Mararonia", "Kota Rizi", "Bithkoti" };
            return dishes;
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
 