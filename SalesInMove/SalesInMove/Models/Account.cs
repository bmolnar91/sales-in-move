using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesInMove.Models
{
    public class Account: IdentityUser 
    {
        // //model class of account who seeks to work
        // public string FirstName { get; set; }
        // public string LastName { get; set; }
        // [Required]
        // public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        public string JobTitle { get; set; }
        public string Education { get; set; }
        public string[] Languages { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? TurnoverLastYear { get; set; }
        public string ProfilePicture { get; set; }
        public string ProfileVideo { get; set; }
        public bool IsSubscribed { get; set; } = false;
        public bool HasPersonalityTest { get; set; } = false;
        public int Eletkor{ get; set; }
        public string Varos { get; set; }
        public bool Jogositvany { get; set; }
        public bool SalesKurzusElofizetes { get; set; }
        public int ErtekesitoiForgalom { get; set; }
    }
}
