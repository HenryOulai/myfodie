using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyFodie.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyFodie.Pages.Shared.Components.LoginMenu
{
    public class FakeLoginMenu : ViewComponent
    {
        private readonly AppDbContext _database;
        private readonly AccessControl _accessControl;

        public FakeLoginMenu(AppDbContext database, AccessControl accessControl)
        {
            _database = database;
            _accessControl = accessControl;
        }

        public async Task<IViewComponentResult> InvokeAsync(int maxPriority, bool isDone)
        {
            var accounts = await _database.Accounts.OrderBy(a => a.Name).ToListAsync();
            var selectList = accounts.Select(p => new SelectListItem
            {
                Value = p.ID.ToString(),
                Text = p.Name,
                Selected = p.ID == _accessControl.LoggedInAccountID
            });
            return View(selectList);
        }
    }
}
