using Microsoft.AspNetCore.Mvc;
using MvcModel.Contexts;
using MvcModel.Models;

namespace MvcModel.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController()
    {
        _context = new AppDbContext();
    }

    public IActionResult Index()
    {
        List<TemplateWebsite> templates = _context.TemplateWebsites.ToList();
        return View(templates);
    }
}
