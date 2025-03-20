using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UKW_sklep_czw.DAL;

namespace UKW_sklep_czw.Controllers
{
    public class HomeController : Controller
    {
        FilmsContext db;

		public HomeController(FilmsContext db)
		{
			this.db = db;
		}

		public IActionResult Index()
        {
            //var kategorie = db.Categories.ToList();

			return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult footerSites(string viewName)
        {
            return View(viewName);
        }
    }
}
