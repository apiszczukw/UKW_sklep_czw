using Microsoft.AspNetCore.Mvc;
using UKW_sklep_czw.DAL;
using UKW_sklep_czw.Infrastructure;

namespace UKW_sklep_czw.Controllers
{
    public class CartController : Controller
    {
        FilmsContext db;

        public CartController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var cart = CartManager.GetItems(HttpContext.Session);
            ViewBag.Total = CartManager.GetCartValue(HttpContext.Session);

            return View(cart);
        }

        public IActionResult AddToCart(int filmId)
        {
            CartManager.AddToCart(HttpContext.Session, filmId, db);

            // on tutaj to "Cart" widzi jako argument do przekazania do metody
            return RedirectToAction("Index");
        }
    }
}
