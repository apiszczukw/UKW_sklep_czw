using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UKW_sklep_czw.Models.Users;

namespace UKW_sklep_czw.Controllers
{
    public class AccountController : Controller
    {
        UserManager<AppUser> userManager;

        SignInManager<AppUser> signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Login()
        {
            var result = await signInManager.PasswordSignInAsync("TestUser", "Test", false, false);

            if (result.Succeeded)
            {
                ViewBag.msg = "Pomyślnie zalogowano";
            }
            else
            {
                ViewBag.msg = "Błędy: " + result;
            }

            return View();
        }

        public async Task<IActionResult> Register()
        {

            var user = await userManager.FindByNameAsync("TestUser2");

            if (user != null)
            {
                ViewBag.msg = "Użytkownik o podanej nazwie już istnieje!";
            }
            else
            {
                user = new AppUser()
                {
                    UserName = "TestUser2",
                    Email = "testuser@ukw.edu.pl",
                    FirstName = "Jan",
                    LastName = "Kowalski"
                };

                var result = await userManager.CreateAsync(user, "Tes");

                ViewBag.msg = result.ToString();
            }

            return View();
        }
    }
}
