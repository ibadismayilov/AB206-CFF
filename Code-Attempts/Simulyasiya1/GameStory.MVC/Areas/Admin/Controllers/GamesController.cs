using GameStore.BL.Services;
using GameStore.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GamesController : Controller
    {
        private readonly TrendingGamesService _trendingGamesService;

        public GamesController()
        {
            _trendingGamesService = new TrendingGamesService();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TrendingGames trendingGames)
        {
            _trendingGamesService.CreateGames(trendingGames);
            return View();
        }
    }
}
