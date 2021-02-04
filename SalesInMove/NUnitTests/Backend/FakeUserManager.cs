
using System;
using System.Collections.Generic;
using System.Text;
using SalesInMove.Models;
using Microsoft.AspNetCore.Identity;
using Moq;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;

namespace SalesInMove.NUnitTests.Backend
{   
    public class FakeUserManager : UserManager<IdentityUser>
    {
        //it will be used my the mocking framework, creating a fake identityUser
        public FakeUserManager() : base(new Mock<IUserStore<IdentityUser>>().Object,
                                        new Mock<IOptions<IdentityOptions>>().Object,
                                        new Mock<IPasswordHasher<IdentityUser>>().Object,
                                        new IUserValidator<IdentityUser>[0],
                                        new IPasswordValidator<IdentityUser>[0],
                                        new Mock<ILookupNormalizer>().Object,
                                        new Mock<IdentityErrorDescriber>().Object,
                                        new Mock<IServiceProvider>().Object,
                                        new Mock<ILogger<UserManager<IdentityUser>>>().Object)
                                        { }
    }
}
