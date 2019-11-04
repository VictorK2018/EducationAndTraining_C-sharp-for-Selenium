using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupRemovalTests: AuthTestBase
    {
        [Test]
        public void GroupYesTest()
        {
            app.Groups.Remove(1);
            
            //app.Navigator.GoGroupsPage();
            //app.Groups
            //    .SelectGroup(1)            
            //    .RemoveGroup()           
            //    .ReturnToGroupsPage();

            //driver.FindElement(By.LinkText("Logout")).Click();
        }

        public void GroupNoTest()
        {
            // prepare-if previous test was with Group, set up Start for this test:
            app.Groups.Remove(1);

            // action - create Group
            GroupData group = new GroupData("nnn");
            group.Header = "hhh";
            group.Footer = "fff";

            app.Groups.Create(group);

            //verification
            Assert.IsTrue(app.Groups.IsGroupPresent(1));
        }


        //}

    }
}
