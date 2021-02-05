using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Moq;
using SalesInMove;
using SalesInMove.Controllers;
using SalesInMove.DatabaseRelated;
using SalesInMove.Models;
using SalesInMove.NUnitTests.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace NUnitTests.Backend
{
    public class AccountControllerTest : IClassFixture<Testfixture<Startup>>
    {
        //this class provides to be testing the accounter controller class
        private ISalesmenRepository Repository { get; set; }
        private AccountController AccountController { get; set; }

        public AccountControllerTest(Testfixture<Startup> fixture)
        {
            var users = new List<Account>
            {
                new Account
                {
                    UserName = "Test",
                    Id = Guid.NewGuid().ToString(),
                    Email = "test@test.it"
                }
            }.AsQueryable();

            var fakeUserManager = new Mock<FakeUserManager>();
            fakeUserManager.Setup(x => x.Users).Returns(users);
            fakeUserManager.Setup(x=>x.DeleteAsync(It.IsAny<Account>())).ReturnsAsync(IdentityResult.Success);
            fakeUserManager.Setup(x => x.CreateAsync(It.IsAny<Account>(), It.IsAny<string>()));
            fakeUserManager.Setup(x => x.UpdateAsync(It.IsAny<Account>())).ReturnsAsync(IdentityResult.Success);

            //var querable = users.AsQueryable();
            //var mockSet = new Mock<DbSet<Account>>();
            //mockSet.As<IQueryable<Account>>().Setup(m => m.Expression).Returns(querable.Expression);
            //mockSet.As<IQueryable<Account>>().Setup(m => m.ElementType).Returns(querable.ElementType);
            //mockSet.As<IQueryable<Account>>().Setup(m => m.GetEnumerator()).Returns(querable.GetEnumerator);
            //mockSet.As<IQueryable<Account>>().Setup(m => m.Provider).Returns(querable.Provider);
            //mockSet.Setup(d => d.Add(It.IsAny<Account>()));
            
            
            var mockSet = new Mock<DbSet<Account>>();
            var mockContext = new Mock<SalesmenDbContext>();
            mockContext.Setup(x => x.Accounts).Returns(mockSet.Object);
            Repository = new SQLSalesmenRepository(mockContext.Object);

            var mapper = (IMapper)fixture.Server.Host.Services.GetService(typeof(IMapper));
            var passwordHasher = (IPasswordHasher<Account>)fixture.Server.Host.Services.GetService(typeof(IPasswordHasher<Account>));
            var userValidator = new Mock<IUserValidator<Account>>();
            userValidator.Setup(x => x.ValidateAsync(It.IsAny<UserManager<Account>>(), It.IsAny<Account>())).ReturnsAsync(IdentityResult.Success);
            var passwordValidator = new Mock<IPasswordValidator<Account>>();
            passwordValidator.Setup(x => x.ValidateAsync(It.IsAny<UserManager<Account>>(), It.IsAny<Account>(), It.IsAny<string>()))
                    .ReturnsAsync(IdentityResult.Success);

            var FakeSignInManager = new Mock<FakeSignInManager>();
            FakeSignInManager.Setup(x => x.PasswordSignInAsync(It.IsAny<Account>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>()))
                    .ReturnsAsync(SignInResult.Success);

            AccountController = new AccountController(fakeUserManager.Object, FakeSignInManager.Object, new System.Net.Mail.SmtpClient());

        }
    }
}
