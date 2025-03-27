using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UKW_sklep_czw.DAL;

namespace UKW_sklep_czw.ViewComponents
{
    public class SideMenuViewComponent : ViewComponent
    {
        FilmsContext db;

        public SideMenuViewComponent(FilmsContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(string categoryName)
        {
            var category = db.Categories.Include("Films").Where(c => c.Name.ToUpper() == categoryName.ToUpper()).FirstOrDefault();

            var films = category.Films.OrderBy(f => f.Title).ToList();

            return await Task.FromResult(View("_SideMenu", films));
        }
    }
}
