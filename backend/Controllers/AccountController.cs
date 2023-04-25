using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SafeCode.Models;

namespace backend.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> singInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.singInManager = signInManager;
        }

        [HttpGet]
        public IActionResult RegisterView()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterView(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Name,
                    Email = model.Email
                };
                var result = new IdentityResult();
                try
                {
                    if (model.Password == "" || model.Password == null)
                    {
                        return RedirectToAction("index", "home");

                    }
                    result = await userManager.CreateAsync(user, model.Password);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"ERRO::::::!!!!!!! {e}");
                    throw;
                }


                if (result.Succeeded)
                {
                    await singInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult LoginView()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginView(LoginViewModel model)
        {

            try
            {
                // if (ModelState.IsValid)
                // {
                //     var result = await singInManager.PasswordSignInAsync(
                //         model.Email, model.Password, false, false);

                //     if (result.Succeeded)
                //     {
                //         return RedirectToAction("index", "home");
                //     }
                //     else
                //     {
                //         ModelState.AddModelError(string.Empty, "login invalido");
                //     }
                // }
                Console.WriteLine("ok");
            }

            catch (System.Exception)
            {

                Console.WriteLine("error model state");
            }

            return RedirectToAction("RegisterView", "Account");
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await singInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }






    }
}