using Microsoft.AspNetCore.Mvc;
using MyFirstWebApplication.Context;
using MyFirstWebApplication.Models;

namespace MyFirstWebApplication.Controllers.AuthController
{
    public class AuthController : Controller
    {
        private MyFirstWebAppDbContext _myFirstWebAppDbContext;

        public AuthController(MyFirstWebAppDbContext myFirstWebAppDbContext)
        {
            _myFirstWebAppDbContext = myFirstWebAppDbContext;
        }

        public IActionResult Auth()
        {
            return View();
        }

        [HttpPost]
        public void AddUser(User user)
        {
            _myFirstWebAppDbContext.Users.Add(user);
            _myFirstWebAppDbContext.SaveChanges();
        }
    }
}
