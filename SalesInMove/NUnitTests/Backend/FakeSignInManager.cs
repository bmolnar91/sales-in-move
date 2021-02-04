using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using SalesInMove.NUnitTests.Backend;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests.Backend
{
    public class FakeSignInManager :SignInManager<IdentityUser>
    {
        //this fakes usermanager and it will be added to the mocking famework
        public FakeSignInManager() : base(new FakeUserManager(),
                                        new HttpContextAccessor(),
                                        new Mock<IUserClaimsPrincipalFactory<IdentityUser>>().Object,
                                        new Mock<IOptions<IdentityOptions>>().Object,
                                        new Mock<ILogger<SignInManager<IdentityUser>>>().Object,
                                       new Mock<IAuthenticationSchemeProvider>().Object,
                                       new Mock<IUserConfirmation<IdentityUser>>().Object
                                       )
        { }
    }
}
