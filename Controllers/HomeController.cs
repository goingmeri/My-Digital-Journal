using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyDigitalJournal.Models;

namespace MyDigitalJournal.Controllers;

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

    public IActionResult About()
    {
        return View();
    }

    public IActionResult MyStory()
    {
        return View();
    }

    public IActionResult Favorites()
    {
        return View();
    }

    public IActionResult Guestbook()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
