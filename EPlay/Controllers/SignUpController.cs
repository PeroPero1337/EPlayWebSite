using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPlay.Repository;
using EPlay.Models;

namespace EPlay.Controllers
{
    //Login and registration are combined in this controller
    //TODO:
    //Download ASP.NET Core Identity, create registration and login
    public class SignUpController : Controller
    {
        private readonly IAccountRepository _accountRepository;

        public SignUpController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpGet]
        //Login page
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountRepository.PasswordSignInAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Nepravilna prijava");
            }
            return View(user);
        }

        public async Task<IActionResult> Logout()
        {
            await _accountRepository.SingOutAsync();
            return RedirectToAction("Index", "Home");

        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserWithPass user)
        {
            using(var db = new EPlayContext())
            {
                if (ModelState.IsValid)
                {
                    var result = await _accountRepository.CreatUserAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction("Index", "SignUp");
                    else
                    {
                        foreach (var errorMessage in result.Errors)
                        {
                            ModelState.AddModelError("", errorMessage.Description);
                        }
                    }
                    ModelState.Clear();
                }
                return View(user);
            }
        }
    }
}
