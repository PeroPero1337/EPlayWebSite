using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EPlay.Models
{
    public class RegisteredUser : IdentityUser
    {
        [Required(ErrorMessage = "Required")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only letters allowed")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only letters allowed")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required")]
        public override string UserName { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Sex { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime DateOfBirth { get; set; }

        public DateTime DateJoined { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression(@"([\w\.\-_]+)?\w+@[\w-_]+(\.\w+){1,}", ErrorMessage = "Please enter a valid email address")]
        public override string Email { get; set; }
    }
}
