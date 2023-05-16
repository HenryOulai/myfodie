﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyFodie.Data;

namespace MyFodie.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext database;

        public IndexModel(AppDbContext database)
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
