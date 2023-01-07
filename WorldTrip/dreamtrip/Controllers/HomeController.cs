using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dreamtrip.Models;
using touristdata;
using mytrip;

namespace dreamtrip.Controllers;

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

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Welcome()
    {
        return View();
    }
    
    public IActionResult Preregister(string fname,string lname,string email,string pass)
    {
        Tourist person = new Tourist(fname,lname,email,pass);
        List<Tourist> travllerlist = TouristData.populatetourist();
        // List<Tourist> travllerlist = new List<Tourist>();
        travllerlist.Add(person);
        TouristData.SerializationTourist(travllerlist);
        return Redirect("/Home/Welcome");
    }

    // public IActionResult Validate()
    // {

    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
