using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyApp.Models;

namespace MyApp.Controllers
{
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
        public IActionResult ComponentTest01()
        {
            //TODO: Implement Realistic Implementation
            return View();
        }
        public IActionResult ComponentTest02()
        {
            //TODO: Implement Realistic Implementation
            return View();
        }
        public IActionResult ComponentTest03()
        {
            //TODO: Implement Realistic Implementation
            return View();
        }
        public IActionResult ComponentTest04()
        {
            //TODO: Implement Realistic Implementation
            return View();
        }
         public IActionResult ComponentTest05()
        {
            //TODO: Implement Realistic Implementation
            return View();
        }
          public IActionResult ComponentTest06()
        {
            //TODO: Implement Realistic Implementation
            return View();
        }
        public IActionResult Component01()
        {
            return View();
        }
        public IActionResult Learn00()
        {
            //TODO: Implement Realistic Implementation
            return View();
        }
        public IActionResult Learn01()
        {
            //TODO: Implement Realistic Implementation
            return View();
        }
        public IActionResult Learn02()
        {
            //TODO: Implement Realistic Implementation
            return View();
        }
        public IActionResult Learn03()
        {
            //TODO: Implement Realistic Implementation
            return View();
        }
        public IActionResult Learn04()
        {
            return View();
        }
        public IActionResult Learn05()
        {
            return View();
        }
        public IActionResult Learn06()
        {
            return View();
        }
        public IActionResult Learn07()
        {
            return View();
        }
        public IActionResult Learn08()
        {
            return View();
        }
        public IActionResult Learn09()
        {
            return View();
        }
        public IActionResult Learn10()
        {
            return View();
        }

        public IActionResult Learn11()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [IgnoreAntiforgeryToken]
        public IActionResult Learn11(MyViewModel model)
        {

            return Ok();
        }

        public IActionResult Learn12()
        {
            return View();
        }
        public IActionResult Learn13()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Learn13(MyViewModel model)
        {
            return View();
        }
        public IActionResult Learn14()
        {
            return View();
        }
        public IActionResult Learn15()
        {
            return View();
        }
        public IActionResult Learn16()
        {
            return View();
        }
        public IActionResult Learn17()
        {
            return View();
        }
        public IActionResult Learn100()
        {
            return View();
        }

    }
}
