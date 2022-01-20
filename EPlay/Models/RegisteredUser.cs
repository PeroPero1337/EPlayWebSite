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
        [Required(ErrorMessage = "Obvezno izpolnite polje")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Dovoljene so samo črke")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Obvezno izpolnite polje")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Dovoljene so samo črke")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Obvezno izpolnite polje")]
        public override string UserName { get; set; }

        [Required(ErrorMessage = "Obvezno izpolnite polje")]
        public string Sex { get; set; }

        [Required(ErrorMessage = "Obvezno izpolnite polje")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime DateOfBirth { get; set; }


        [Required(ErrorMessage = "Obvezno izpolnite polje")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Obvezno izpolnite polje")]
        [RegularExpression(@"([\w\.\-_]+)?\w+@[\w-_]+(\.\w+){1,}", ErrorMessage = "Prosim vnesite Email naslov")]
        public override string Email { get; set; }
    }
}
