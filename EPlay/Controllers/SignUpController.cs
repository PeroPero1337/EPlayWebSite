using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPlay.Controllers
{
    //Login and registration are combined in this controller
    //TODO:
    //Download ASP.NET Core Identity, create registration and login
    public class SignUpController : Controller
    {
        //Login page
        public IActionResult Index()
        {
            return View();
        }


        //Registration page
        public IActionResult Register()
        {
            return View();
        }
    }
}
