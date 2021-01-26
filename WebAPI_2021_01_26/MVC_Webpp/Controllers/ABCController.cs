using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Webpp.Controllers
{
    public class ABCController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
