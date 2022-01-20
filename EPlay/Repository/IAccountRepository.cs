using EPlay.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPlay.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreatUserAsync(UserWithPass user);

        Task<SignInResult> PasswordSignInAsync(LoginUser loginUserModel);

        Task SingOutAsync();
    }
}
