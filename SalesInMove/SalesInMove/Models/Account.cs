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
        //model class of account who seeks to work
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }

        public int Eletkor{ get; set; }
        public string Varos { get; set; }
        public string Szakterulet { get; set; }
        public string Vegzettseg { get; set; }
        public List<string> Nyelvek { get; set; }
        public bool Jogositvany { get; set; }
        public bool SalesKurzusElofizetes { get; set; }
        public int ErtékesitoiForgalom { get; set; }
        public bool SzemelyisegTeszt { get; set; }
        public string Picture { get; set; }


    }
}
