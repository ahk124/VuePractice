using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class ParsClickController : Controller
    {
        private readonly ILogger _logger;
        public ParsClickController(ILogger<ParsClickController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Form01()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Form01(MyViewModel myViewModel)
        {
            _logger.LogInformation($"log is  "+myViewModel.FirstName + "   "+ DateTime.Now);    
            return View();
        }
    }
}