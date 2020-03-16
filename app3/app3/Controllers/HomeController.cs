using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace app3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult pag1()
        {
            return View();
        }
        public IActionResult pag2()
        {
            return View();
        }
        public IActionResult pag3()
        {
            return View();
        }
    }
}
