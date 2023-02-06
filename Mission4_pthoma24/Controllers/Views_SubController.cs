using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mission4_pthoma24.Models;

namespace Mission4_pthoma24.Controllers
{
    public class Views_SubController : Controller
    {
        // Return Index Page View
        public IActionResult Index ()
        {
            return View();
        }

        [HttpGet]
        // Return Grade Calculator Page View (Get Method)
        public IActionResult GradeCalculator ()
        {
            return View();
        }

        [HttpPost]
        // Method Overloading (Post Method)
        public IActionResult GradeCalculator (GradeModel model)
        {
            return View();
        }
    }
}
