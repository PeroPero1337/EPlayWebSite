using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPlay.Models;

namespace EPlay.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            using(var db = new EPlayContext())
            {
                var all = db.registered_users.FirstOrDefault(x => x.UserName == User.Identity.Name);
                return View(all);
            }
        }
    }
}
