using EPlay.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPlay.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<RegisteredUser> _userManager;

        public ProfileController(UserManager<RegisteredUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            using (var db = new EPlayContext())
            {
                ProfileModel profile = new ProfileModel(db, User.Identity.Name);
                return View(profile);
            }
            
        }

        public async Task<IActionResult> Manage(string id)
        {
            using (var db = new EPlayContext())
            {
                var user = db.registered_users.FirstOrDefault(x => x.Id == id);
                var role = await _userManager.GetRolesAsync(user);
                UserWithRole output = new UserWithRole(user,role.ToList());
                return View(output);
            }
        }
    }
}
