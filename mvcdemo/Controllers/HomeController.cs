using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcdemo.Data;
using mvcdemo.Models;

namespace mvcdemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private VCBDataContext dbContext;

    public HomeController(ILogger<HomeController> logger, VCBDataContext _dbContext)
    {
        _logger = logger;
        dbContext = _dbContext;
    }

    public IActionResult Index()
    {
        //return Redirect("Home/Hello");
        //return RedirectToAction("Hello", "Home");
        return View();
    }

    public IActionResult Hello()
    {
        List<VCBUser> lstMyAcc = new List<VCBUser>();
        lstMyAcc =  dbContext.vCBUsers.ToList();

        return View(lstMyAcc); //Truyen data tu controller xuong view qua ViewModel
    }

    public IActionResult Hello2()
    {
        List<VCBUser> lstMyAcc = new List<VCBUser>();
        lstMyAcc.Add(new VCBUser(){Id = 1, Name = "Hoang Xuan Bach", Department="IT"});
        lstMyAcc.Add(new VCBUser(){Id = 2, Name = "Hoang Xuan Vinh", Department="Sport"});
        ViewBag.Users = lstMyAcc; //Truyen data tu controller xuong view qua viewbag
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
