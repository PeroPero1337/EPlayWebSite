using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EPlay.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Obvezno izpolnite polje")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Obvezno izpolnite polje")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
