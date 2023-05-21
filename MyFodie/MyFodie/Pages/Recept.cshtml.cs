using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyFodie.Data;
using MyFodie.Models; // Ensure to include the models namespace if Recipe is there.
using System.Linq;

namespace MyFodie.Pages
{
    public class RecipeIndexModel : PageModel
    {
        private readonly AppDbContext _database;

        public RecipeIndexModel(AppDbContext database)
        {
            _database = database;
        }

        public IList<Recipe> Recipes { get; set; }  // Property to hold the recipes

        public IActionResult OnGet()
        {
            Recipes = _database.Recipes.OrderBy(a => a.Name).ToList();
            return Page();
        }
    }
}
