﻿using Microsoft.AspNetCore.Mvc;

namespace Scholar.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
