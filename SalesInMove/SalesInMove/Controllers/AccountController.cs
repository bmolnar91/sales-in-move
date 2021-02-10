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
using System.Web;

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
            //register some services throughout the IOC
            _userManager = userManager;
            _signInManager = signInManager;
            _emailService = emailService; 
        }

        [HttpPost("login")]
        public async Task<Microsoft.AspNetCore.Identity.SignInResult> Login([FromForm] Account model)
        {
            //1.getting a request from frontend, and generating a model object from JSON by it
            //2. getting an identityuser from the database which matches with we got from the JSON by email adress
            //3. and if we got , we are signing it in order to be available throughout the IOC.
            IdentityUser user = await _userManager.FindByEmailAsync(model.Email);

            var signInResult = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

            return signInResult;
        }

        [HttpPost("logout")]
        public async void Logout()
        {
            // we logging out to free the signinmanager
            await _signInManager.SignOutAsync();
        }

        [HttpGet("confirmation/{id}")]
        public async Task<IdentityUser> VerifyEmail(string id, string code)
        {   
            //this methods gets activated when the user clicks on the link on his/her email provider, and redirect here where his/her email gets confirmed and able to sign in
             var user = await _userManager.FindByIdAsync(id);
            if (user == null) throw new Exception();
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                return user;
            }

            return null;
        }


        [HttpPost("register")]
        public async Task<IdentityResult> Register([FromForm] Account model)
        {
            // registers users in the database. we get an account form which we are converting into an IdentityUser
            //also using the SMTP protocal (if we are able to create user) to send comfirmation email to the user's email
            var user = new Account
            {
                UserName = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                PasswordHash = model.Password
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var link = Url.Action(nameof(VerifyEmail), "Account", new { user.Id, code }, Request.Scheme, Request.Host.ToString());

                var msg = new MailMessage(from: "csharptw5@gmail.com", to: user.Email, subject: "Email Verification", body: $"<a href=\"{link}\">Verify your email</a>");
                msg.IsBodyHtml = true;
                await _emailService.SendMailAsync(msg);
            }

            return result;
        }
    }
}
