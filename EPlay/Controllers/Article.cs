using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPlay.Controllers
{
    //delete this
    public class Article : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
