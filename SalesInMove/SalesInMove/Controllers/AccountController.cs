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
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("login")]
        public async Task<Microsoft.AspNetCore.Identity.SignInResult> Login([FromForm] Account model)
        {
            var signInResult = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
            if (signInResult.Succeeded)
            {
                Console.WriteLine("succeeded");
            }

            return signInResult;
        }

        [HttpPost("register")]
        public async Task<IdentityUser> Register([FromForm] Account model)
        {
            var user = new IdentityUser
            {
                UserName = model.Username,
                Email = model.Username,
                PasswordHash = model.Password,
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var signInResult = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                if (signInResult.Succeeded)
                {
                    Console.WriteLine("succeeded");
                }
            }

            return user;


        }

    }
}
