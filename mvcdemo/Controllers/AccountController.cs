using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcdemo.Models;

namespace mvcdemo.Controllers
{
    public class Account : Controller
    {
        private readonly ILogger<Account> _logger;

        public Account(ILogger<Account> logger)
        {
            _logger = logger;
        }

        [HttpGet("/login")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signin(String Username, String Password, Boolean Remember)
        {
            return Content(Username + "-" + Password + "-"+ Remember);
        }

        public IActionResult Signin2([FromForm] LoginModel login, Boolean Remember, [FromQuery]String Username)
        {
            return Content(login.Username + "-" + login.Password + "-"+ Remember + "-"+Username);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}