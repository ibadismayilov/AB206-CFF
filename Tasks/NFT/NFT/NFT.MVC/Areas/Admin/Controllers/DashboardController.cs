﻿using Microsoft.AspNetCore.Mvc;

namespace NFT.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
