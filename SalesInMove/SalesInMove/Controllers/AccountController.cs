using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NETCore.MailKit.Core;
using SalesInMove.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SalesInMove.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly SmtpClient _emailService;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, SmtpClient emailService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailService = emailService; 
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

        [HttpPost("logout")]
        public async void Logout()
        {
            await _signInManager.SignOutAsync();
        }

        [HttpPost("confirmation")]
        public async Task<IdentityUser> VerifyEmail(string userId, string code)
        {
            var user = await _userManager.FindByIdAsync(userId);
            //if (user == null) return NullReferenceException();
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                return user;
            }

            return null;
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
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                await _emailService.SendMailAsync(new MailMessage(from:"csharptw5@gmail.com",to: "lilaalex95@gmail.com", subject: "email verify", body: "email sent"));
            }

            return user;
        }

    }
}
