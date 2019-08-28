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
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoGroupsPage();
            InitGroupCreation();
            GroupData group = new GroupData("nnn");
            group.Header = "hhh";
            group.Footer = "fff";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();

            //driver.FindElement(By.LinkText("Logout")).Click();
        }

    }
}

