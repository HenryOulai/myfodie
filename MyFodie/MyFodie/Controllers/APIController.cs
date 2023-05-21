using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFodie.Data;
using MyFodie.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MyFodie.Controllers
{
    [Route("/api")]
    [ApiController]
    public class APIController : ControllerBase
    {
        private readonly AppDbContext database;

        public APIController(AppDbContext database)
        {
            this.database = database;
        }

        // GET: api/recipes
        [HttpGet("recipes")]
        public async Task<ActionResult> GetRecipes()
        {
            var recipes = await database.Recipes.ToListAsync();
            return Ok(recipes);
        }

        // POST: api/recipes
        [HttpPost("recipes")]
        public async Task<ActionResult> CreateRecipe([FromBody] Recipe recipe)
        {
            if (recipe == null || string.IsNullOrEmpty(recipe.Name) || string.IsNullOrEmpty(recipe.Description))
            {
                return BadRequest("Invalid recipe data.");
            }

            database.Recipes.Add(recipe);
            await database.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRecipe), new { id = recipe.ID }, recipe);
        }

        // GET: api/recipes/{id}
        [HttpGet("recipes/{id}")]
        public async Task<ActionResult> GetRecipe(int id)
        {
            var recipe = await database.Recipes.FindAsync(id);

            if (recipe == null)
            {
                return NotFound("Recipe not found.");
            }

            return Ok(recipe);
        }

        // PUT: api/recipes/{id}
        [HttpPut("recipes/{id}")]
        public async Task<ActionResult> UpdateRecipe(int id, [FromBody] Recipe updatedRecipe)
        {
            if (id != updatedRecipe.ID)
            {
                return BadRequest("Mismatched recipe ID.");
            }

            if (string.IsNullOrEmpty(updatedRecipe.Name) || string.IsNullOrEmpty(updatedRecipe.Description))
            {
                return BadRequest("Invalid recipe data.");
            }

            try
            {
                database.Entry(updatedRecipe).State = EntityState.Modified;
                await database.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecipeExists(id))
                {
                    return NotFound("Recipe not found.");
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/recipes/{id}
        [HttpDelete("recipes/{id}")]
        public async Task<ActionResult> DeleteRecipe(int id)
        {
            var recipe = await database.Recipes.FindAsync(id);

            if (recipe == null)
            {
                return NotFound("Recipe not found.");
            }

            database.Recipes.Remove(recipe);
            await database.SaveChangesAsync();

            return NoContent();
        }

        // A helper method to check if a recipe exists
        private bool RecipeExists(int id)
        {
            return database.Recipes.Any(r => r.ID == id);
        }
    }
}
