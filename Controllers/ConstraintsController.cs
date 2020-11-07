using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace rest_aspnet_core.Controllers
{
    public class ConstraintsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
