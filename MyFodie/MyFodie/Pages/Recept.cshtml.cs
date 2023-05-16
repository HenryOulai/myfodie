using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyFodie.Data;

namespace MyFodie.Pages
{
    public class ReceptIndex : PageModel
    {
        private readonly AppDbContext database;

        public ReceptIndex(AppDbContext database)
        {
            this.database = database;
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
