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
        private UserContext db;
        public HomeController(UserContext context)
        {
            db = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            List<Message> msg = db.Messages.ToList();
            return View(msg);
        }

        
    }
}
