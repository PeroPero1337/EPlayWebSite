using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPlay.Models;
using Microsoft.AspNetCore.Identity;

namespace EPlay.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<RegisteredUser> _userManager;
        private readonly SignInManager<RegisteredUser> _signInManager;

        public AccountRepository(UserManager<RegisteredUser> userManager, SignInManager<RegisteredUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IdentityResult> CreatUserAsync(UserWithPass userModel)
        {
            var user = new RegisteredUser()
            {
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                Sex = userModel.Sex,
                DateOfBirth = userModel.DateOfBirth,
                Country = userModel.Country,
                Email = userModel.Email,
                UserName = userModel.UserName
            };
            var result = await _userManager.CreateAsync(user, userModel.Pass);
            return result;
        }

        public async Task<SignInResult> PasswordSignInAsync(LoginUser loginUserModel)
        {
            var result = await _signInManager.PasswordSignInAsync(loginUserModel.Username, loginUserModel.Password, loginUserModel.RememberMe, false);
            return result;
        }

        public async Task SingOutAsync()
        {
            await _signInManager.SignOutAsync();
        }

    }
}
