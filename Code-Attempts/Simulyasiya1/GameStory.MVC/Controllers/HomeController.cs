using GameStore.BL.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameStory.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly TrendingGamesService _trendingGamesService;

        public HomeController()
        {
            _trendingGamesService = new TrendingGamesService();
        }

        public IActionResult Index()
        {
            var result = _trendingGamesService.GetAllGames();
            return View(result);
        }
    }
}
