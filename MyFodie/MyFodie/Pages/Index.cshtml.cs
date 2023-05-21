using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyFodie.Data;
using MyFodie.Models;
using System.Linq;

namespace MyFodie.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _database;

        public IndexModel(AppDbContext database)
        {
            _database = database;
        }

        public IActionResult OnGet()
        {
            var samples = _database.Recipes.OrderBy(a => a.Name);
            var show = samples.ToList();
            ViewData["ShowData"] = show;
            return Page();
        }
    }
}
