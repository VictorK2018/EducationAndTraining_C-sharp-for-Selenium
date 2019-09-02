using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupCreationTests: TestBase
    {
        
        [Test]
        public void GroupCreationTest()
        {
            //app.Navigator.GoGroupsPage();

            GroupData group = new GroupData("nnn");
            group.Header = "hhh";
            group.Footer = "fff";

            app.Groups.Create(group);

            //driver.FindElement(By.LinkText("Logout")).Click();
        }

    }
}

