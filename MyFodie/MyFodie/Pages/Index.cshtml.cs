using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult OnGet()
        {
            var samples = database.Recepts.OrderBy(a => a.Name);
            var show = samples.ToList();
            ViewData["ShowData"] = show;
            return Page();
        }
    }
}
