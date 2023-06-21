using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lab8.Models;

namespace lab8.Controllers;

public class BookController : Controller
{
            private static List<Book> books = new List<Book>();

    private readonly ILogger<HomeController> _logger;

    public BookController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
                    ViewBag.Books = books;
            return View();

    }
    public IActionResult Book()
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
