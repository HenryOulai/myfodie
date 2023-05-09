﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyFodie.Data;

namespace MyFodie.Pages.Shared.Components.LoginMenu
{
    public class FakeLoginMenu : ViewComponent
    {
        private readonly AppDbContext database;
        private readonly AccessControl accessControl;

        public FakeLoginMenu(AppDbContext database, AccessControl accessControl)
        {
            this.database = database;
            this.accessControl = accessControl;
        }

        public async Task<IViewComponentResult> InvokeAsync(int maxPriority, bool isDone)
        {
            var accounts = database.Accounts.OrderBy(a => a.Firstname);
            var selectList = accounts.Select(p => new SelectListItem
            {
                Value = p.ID.ToString(),
                Text = p.Firstname,
                Selected = p.ID == accessControl.LoggedInAccountID
            });
            return View(selectList);
        }
    }
}
