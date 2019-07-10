using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Template_Core2._1_MVC_Bootstrap4
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}