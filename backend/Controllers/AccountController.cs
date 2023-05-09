using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using SafeCode.Models;
using SafeCode.Repositories;

namespace backend.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> singInManager;
        private readonly ApplicationDbContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IPostsCrud _postsCrud;


        public AccountController(IHttpContextAccessor httpContextAccessor, IPostsCrud postsCrud, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext dbContext)
        {
            this.userManager = userManager;
            this.singInManager = signInManager;
            _dbContext = dbContext;
            _httpContextAccessor = httpContextAccessor;
            _postsCrud = postsCrud;

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
                var user = new ApplicationUser
                {
                    UserName = model.Name,
                    Email = model.Email,
                };

                var existingUser = await userManager.FindByEmailAsync(model.Email);
                if (existingUser != null)
                {

                    ModelState.AddModelError(string.Empty, "Endereço de email já está em uso.");
                    return View(model);
                }

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
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var result = await singInManager.PasswordSignInAsync(
                        user, model.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("index", "home");
                    }
                    else
                    {
                        ViewData["errormessage"] = "login invalido";
                    }

                }
                else
                {
                    ViewData["errormessage"] = "login invalido";
                }
            }



            ModelState.AddModelError(string.Empty, "login invalido");
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await singInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }

        [Authorize]
        [Route("Account/ProfileView/{nomeUsuario}")]
        public async Task<IActionResult> ProfileView(string nomeUsuario)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (userId == null)
            {
                return RedirectToAction("index", "home");
            }

            if (string.IsNullOrEmpty(nomeUsuario))
            {
                nomeUsuario = _httpContextAccessor.HttpContext.User.Identity.Name;
            }

            var user = await userManager.Users
                .Include(u => u.Iquestions)
                .SingleOrDefaultAsync(u => u.UserName == nomeUsuario);

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(string id)
        {
            await _postsCrud.DeletePost(id);
            return RedirectToAction("ProfileView", new { nomeUsuario = User.Identity.Name });

        }
    }
}