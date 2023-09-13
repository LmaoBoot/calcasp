using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using project1.Models;

namespace project1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Message = "Welcome to Project 3";
        return View();
    }

    public IActionResult Page1()
    {
        return View();
    }

    public IActionResult Page2()
    {
        return View();
    }

    public IActionResult Page3()
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
}
