using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NETCore.MailKit.Core;
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
        private readonly IEmailService _emailService;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IEmailService emailService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailService = emailService; 
        }

        [HttpPost("login")]
        public async Task<IdentityUser> Login(Account logger)
        {
            var targetUser =  await _userManager.FindByNameAsync(logger.UserName);
            if(targetUser != null)
            {
                var signInResult = await _signInManager.PasswordSignInAsync(targetUser, logger.Password, false, false);
                if (signInResult.Succeeded)
                {
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(targetUser);
                    await _emailService.SendAsync("lilaalex95@gmail.com", "email verify", $"<a href=\register");
                }

            }
            return targetUser;
        }

        public async Task<IActionResult> VerifyEmail(string userId, string code)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return BadRequest();
            var result = await _userManager.ConfirmEmailAsync(user, code);
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
