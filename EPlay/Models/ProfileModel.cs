using EPlay.Repository;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPlay.Models
{
    //The purpose of this class is to use multiple models in view
    public class ProfileModel
    {
        public IEnumerable<RegisteredUser> allUsers { get; set; }
        public RegisteredUser singleUser { get; set; }

        public ProfileModel(EPlayContext context,string user)
        {
            allUsers = context.registered_users.ToList();
            singleUser = context.registered_users.FirstOrDefault(x => x.UserName == user);
        }

    }
}
