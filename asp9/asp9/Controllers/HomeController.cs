using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace asp9.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "HomeController - Index";
        }
      
    }
}