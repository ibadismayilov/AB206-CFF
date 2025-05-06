using HotelMvc.Contexts;
using HotelMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HotelMvc.Controllers
{
    public class HumanController : Controller
    {
        private readonly HumanDbContext _humanDbContext;

        public HumanController()
        {
            _humanDbContext = new HumanDbContext();
        }
        public IActionResult Index()
        {
            var humans = _humanDbContext.Humans.ToList();
            return View(humans);
        }

        [HttpPost]
        public IActionResult Index(Human human)
        {
            if (ModelState.IsValid)
            {
                _humanDbContext.Humans.Add(human);
                _humanDbContext.SaveChanges();
            }

            var humans = _humanDbContext.Humans.ToList();
            return View(humans);
        }
    }
}
