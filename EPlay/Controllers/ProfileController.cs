using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPlay.Models;
using System.Dynamic;

namespace EPlay.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            //if (User.IsInRole("Admin"))
            //    return RedirectToAction("AdminView","Profile");
            //else
            //    return RedirectToAction("UserView","Profile");

            return View();
            
        }

        //TODO: Change how this works
        //Create partial for adminview



        //Admin controlls ------------------------------------------------------------------------------------------------------------------------------
        public IActionResult AdminView()
        {

            using (var db = new EPlayContext())
            {
                var all = db.registered_users.ToList();
                return View(all);
            }

        }



        //User controlls ------------------------------------------------------------------------------------------------------------------------------
        public IActionResult UserView()
        {
            using (var db = new EPlayContext())
            {
                var single = db.registered_users.FirstOrDefault(x => x.UserName == User.Identity.Name);
                return View(single);
            }
            
        }
    }
}
