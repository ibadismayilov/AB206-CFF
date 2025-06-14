using Makan.DAL.Model;
using MakanBLL.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Makan.PL.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthService _authtService;

        public AuthController()
        {
            _authtService = new AuthService();
        }

        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(registerViewModel);
            }

            var register = _authtService.RegisterFunction(registerViewModel);

            if (!register)
            {
                ModelState.AddModelError("", "User aleready in database");
                return View(registerViewModel);
            }

            return RedirectToAction("Login", "Auth");
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                var loginResult = _authtService.LoginFunction(user);
                if (loginResult)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid credentials");
                }
            }

            return View(user);
        }
    }
}
