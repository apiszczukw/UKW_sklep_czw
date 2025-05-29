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

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

            if (result.Succeeded)
            {
                ViewBag.msg = "Pomyślnie zalogowano";

                return RedirectToAction("Index", "Home");
            }
            else
            {

                ViewBag.msg = "Podano nieprawidłowy login lub hasło";
            }

            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if(!ModelState.IsValid) 
                return View(model);

            var user = await userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                ViewBag.msg = "Użytkownik o podanej nazwie już istnieje!";
            }
            else
            {
                user = new AppUser()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName
                };

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    ViewBag.msg = "Użytkownik pomyślnie zarejestrowany";

                    await signInManager.SignInAsync(user, false);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    var errors = string.Join("\n", result.Errors.ToList().Select(e=> e.Description));

                    ViewBag.msg = "Wystąpiły błędy:\n" + errors;

                }
            }
            return View(model);

        }
    }
}
