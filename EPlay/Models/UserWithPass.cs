using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EPlay.Models
{
    [NotMapped]
    public class UserWithPass : RegisteredUser
    {
        [Required(ErrorMessage = "Obvezno izpolnite polje")]
        [RegularExpression(@"(?=.*\d)(?=.*\W+)(?=.*[a-zA-Z])(?!.*\n).*$", ErrorMessage = "Geslo mora vsebovati 1 število in 1 poseben znak")]
        [Compare("PassCheck", ErrorMessage = "Gesli se ne ujemata!")]
        [DataType(DataType.Password)]
        public string Pass { get; set; }

        [Required(ErrorMessage = "Obvezno izpolnite polje")]
        [DataType(DataType.Password)]
        public string PassCheck { get; set; }
    }
}
