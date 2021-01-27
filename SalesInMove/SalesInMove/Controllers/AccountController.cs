using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SalesInMove.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesInMove.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<Account> _userManager;
        private readonly SignInManager<Account> _signInManager;

        public AccountController(UserManager<Account> userManager, SignInManager<Account> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public async Task<Account> Login(Account logger)
        {
            var targetUser =  await _userManager.FindByNameAsync(logger.UserName);
            if(targetUser != null)
            {
                var signInResult = await _signInManager.PasswordSignInAsync(targetUser, logger.Password, false, false);
                if (signInResult.Succeeded)
                {
                    Console.WriteLine("succeeded");
                }

            }
            return targetUser;
        }


        public async Task<Account> Register(string username, string password)
        {
            var user = new Account
            {
                Username = "csharptw5@gmail.com",
                Password = "Csharp123"
            };

            var result = await _userManager.CreateAsync(user, password);
            if (result.Succeeded)
            {
                var signInResult = await _signInManager.PasswordSignInAsync(user, user.Password, false, false);
                if (signInResult.Succeeded)
                {
                    Console.WriteLine("succeeded");
                }
            }

            return user;


        }

    }
}
