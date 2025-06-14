using Cybor2.BL.Services;
using Cybor2.BL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cybor2.MVC.Controllers;

public class AuthController : Controller
{

    private readonly AuthService _authService;

    public AuthController(AuthService authServicer)
    {
        _authService = authServicer;
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }


    [HttpPost]
    public async Task<IActionResult> Register(AuthCreateVM authCreateVM)
    {
        string result = await _authService.Register(authCreateVM);

        if (result != "OK")
        {
            ModelState.AddModelError(string.Empty, result);
            return View();
        }

        return RedirectToAction(nameof(Login));
    }
}
