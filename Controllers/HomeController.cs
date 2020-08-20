using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using yentrapragada.Models;

namespace yentrapragada.Controllers
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
        public IActionResult WorkExperience()
        {
            return View();
        }
        public IActionResult Education()
        {
            return View();
        }
        public IActionResult SocialMedia()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult References()
        {
            return View();
        }
        public IActionResult Achievements()
        {
            return View();
        }
        public IActionResult AcademicProjects()
        {
            return View();
        }

    }
}
