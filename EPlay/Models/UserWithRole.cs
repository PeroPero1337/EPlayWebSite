using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPlay.Models
{
    public class UserWithRole
    {
        
        public RegisteredUser _user { get; set; }
        public IEnumerable<string> _roles { get; set; }

        public UserWithRole(RegisteredUser user, IEnumerable<string> roles)
        {
            _user = user;
            _roles = roles;
        }
    }
}
