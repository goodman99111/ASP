using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChatASP.Models;
using Microsoft.AspNetCore.Authorization;

namespace ChatASP.Controllers
{

    public class HomeController : Controller
    {
        
        [Authorize]
        public IActionResult Index()
        {
           
            return View();
        }

        
    }
}
