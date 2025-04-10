using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UKW_sklep_czw.DAL;
using UKW_sklep_czw.Migrations;
using UKW_sklep_czw.Models;

namespace UKW_sklep_czw.Controllers
{
    public class FilmsController : Controller
    {
        FilmsContext db;
        IWebHostEnvironment webHost;

        public FilmsController(FilmsContext db, IWebHostEnvironment webHost)
        {
            this.db = db;
            this.webHost = webHost;
        }

        [HttpGet]
        public IActionResult AddFilm()
        {
            AddViewModel model = new AddViewModel();

            model.AllCategories = db.Categories.ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult AddFilm(AddViewModel model)
        {
            var posterFolderPath = Path.Combine(webHost.WebRootPath, "posters");

            var uniquePosterName = model.Poster.FileName + "_" + Guid.NewGuid() + Path.GetExtension(model.Poster.FileName);


            var filePath = Path.Combine(posterFolderPath, uniquePosterName);

            model.Poster.CopyTo(new FileStream(filePath, FileMode.Create));

            model.NewFilm.Poster = uniquePosterName;
            db.Films.Add(model.NewFilm);

            db.SaveChanges();

            return RedirectToAction("AddFilm");
        }



		public IActionResult FilmsList(string categoryName)
        {
            var category = db.Categories.Include("Films").Where(c => c.Name.ToUpper() == categoryName.ToUpper()).Single();
			var films = category.Films.ToList();

			return View(films);
        }

        public IActionResult Details(int filmId)
        {
            var film = db.Films.Find(filmId);

            if (film != null)
            {
                db.Categories.Find(film.CategoryId);
            }

            return View(film);
        }

        public IActionResult AllFilms()
        {
            return View(db.Films.ToList());
        }
    }
}
