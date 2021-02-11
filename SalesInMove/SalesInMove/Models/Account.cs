using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesInMove.Models
{
    public class Account 
    {
        [Key]
        public int EmployeeId { get; set; }
        public string UserId { get; set; }
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
        public int Age { get; set; }
        public string City { get; set; }
        public bool DrivingLicence { get; set; }
        public bool SalesCourseSubscription { get; set; }
        public int SalesTurnOver { get; set; }
        public string Specialisation { get; set; }
        public string PreviousCompany { get; set; }
        public string[] OtherCertificates { get; set; }
        public string[] Pros { get; set; }
        public string[] Cons { get; set; }

        // Amikben fejlődni szeretnék
        public string[] ProgressionIntetions { get; set; }
        public string Motto { get; set; }
        
        [Required]
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
