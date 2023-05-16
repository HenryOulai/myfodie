using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFodie.Data;
using MyFodie.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFodie.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _database;

        public IndexModel(AppDbContext database)
        {
            _database = database;
        }

        // Property to hold the recipes
        public List<Recipe> Recipes { get; set; }

        // Fetch the recipes in OnGet
        public async Task OnGetAsync()
        {
            Recipes = await _database.Recipes.ToListAsync();
        }
    }
}
