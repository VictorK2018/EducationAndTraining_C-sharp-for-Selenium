using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupRemovalTests: TestBase 
    {
                [Test]
        public void GroupRemovalTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoGroupsPage();
            SelectGroup(1);
            RemoveGroup();
            ReturnToGroupsPage();

            //driver.FindElement(By.LinkText("Logout")).Click();
        }
                
    }
}
