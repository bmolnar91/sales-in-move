﻿using Microsoft.AspNetCore.Http;
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
        public async Task<Microsoft.AspNetCore.Identity.SignInResult> Login([FromForm] Account model)
        {
            var signInResult = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

            return signInResult;
        }

        [HttpPost("logout")]
        public async void Logout()
        {
            await _signInManager.SignOutAsync();
        }

        //public async Task<IActionResult> VerifyEmail(string userId, string code)
        //{
        //    var user = await _userManager.FindByIdAsync(userId);
        //    if (user == null) return BadRequest();
        //    var result = await _userManager.ConfirmEmailAsync(user, code);
            
        //}

        [HttpPost("register")]
        public async Task<IdentityResult> Register([FromForm] Account model)
        {
            var user = new IdentityUser
            {
                UserName = model.FirstName + model.LastName,
                Email = model.Email,
                PasswordHash = model.Password,
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            //if (result.Succeeded)
            //{
            //    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            //    await _emailService.SendAsync("lilaalex95@gmail.com", "email verify", $"<a href=\register");
            //}

            return result;


        }

    }
}
