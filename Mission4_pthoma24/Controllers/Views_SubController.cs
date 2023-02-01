using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mission4_pthoma24.Controllers
{
    public class Views_SubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
