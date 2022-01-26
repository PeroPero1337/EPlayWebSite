using EPlay.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPlay.Controllers
{
    public class ChatRoomController : Controller
    {

        public IActionResult Index()
        {
            using (var db = new EPlayContext())
            {
                ProfileModel profile = new ProfileModel(db, User.Identity.Name);
                var currentUser = profile.singleUser;
                if (User.Identity.IsAuthenticated)
                {
                    ViewBag.CurrentUserName = currentUser.UserName;
                }
                var messages = db.messages.ToList();
                return View();
            }
        }

        public async Task<IActionResult> Create(Message message)
        {
            using (var db = new EPlayContext())
            {
                if (ModelState.IsValid)
                {
                    ProfileModel profile = new ProfileModel(db, User.Identity.Name);
                    message.UserName = User.Identity.Name;
                    var sender = profile.singleUser;
                    message.UserId = sender.Id;

                    await db.messages.AddAsync(message);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                return Error();
            }
        }

        private IActionResult Error()
        {
            throw new NotImplementedException();
        }
    }
}
