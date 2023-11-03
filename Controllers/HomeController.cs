using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Validador_de_Fechas.Models;

namespace Validador_de_Fechas.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost]
    public IActionResult Submit(DateModel model)
    {
        if (ModelState.IsValid)
        {
            return View("Result", model);
        }
        return View("Index", model);
    }
}
