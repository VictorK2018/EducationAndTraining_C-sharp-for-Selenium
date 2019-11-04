using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            // prepare-if previous test was with Login, set up Start for this test:
            app.Auth.Logout();

            // action
            AccountData account = new AccountData("admin", "secret");
            app.Auth.Login(account);

            //verification
            Assert.IsTrue(app.Auth.IsLoggedIn(account));
        }

        [Test]
        public void LoginWithInvalidCredentials()
        {
            // prepare-if previous test was with Login, set up Start for this test:
            app.Auth.Logout();

            // action
            AccountData account = new AccountData("admin", "invalidpass");
            app.Auth.Login(account);

            //verification -check:
            Assert.IsFalse(app.Auth.IsLoggedIn(account));
        }

    }
}
