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

        public string City { get; set; }
        public string Expertise { get; set; }
        public string BachelorDegree { get; set; }
        public string EnglishSpeaker { get; set; }
        public List<string> Languages { get; set; }
        public bool DriverLicense { get; set; }
        public bool SalesCourseSubscription { get; set; }
        public int GeneratedSalesInForint { get; set; }


    }
}
