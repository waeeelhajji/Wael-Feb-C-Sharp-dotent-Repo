using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionDemo.Models;

namespace SessionDemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpPost("Login")]
    public IActionResult Login(string UserName)
    {
        HttpContext.Session.SetString("Username",UserName);
        
        return RedirectToAction("Privacy");
    }

    [HttpPost("logout")]
    public IActionResult logout()
    {
        HttpContext.Session.Clear();
        return View("Index");

    }





    public IActionResult Index()
    {

        //! Making session
        
        HttpContext.Session.SetInt32("MyNum",56);
        return View();
    }

    public IActionResult Privacy()
    {

        string? InSession = HttpContext.Session.GetString("Username");

        int? NumInSession = HttpContext.Session.GetInt32("MyNum");


         if( InSession == null)
         {
            return RedirectToAction("Index");
         }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
