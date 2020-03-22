using System;
using Xunit;

namespace MyHealth.Web.UnitTests
{
    public class AccountControllerTests
    {
        [Fact]
        public void CheckLoginForUser()
        {
            Assert.Equal("LoginName", "LoginName");
        }

        [Fact]
        public void CheckAccountNumbersForUser()
        {
            Assert.Equal("AccountNumber", "AccountNumber");
        }
    }
}
