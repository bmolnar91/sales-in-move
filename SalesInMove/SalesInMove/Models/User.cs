using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SalesInMove.Models
{
    public class User: IdentityUser
    {
        public int UserType { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}