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
        public void GroupRemovalTest()
        {
            // prepare to test
            app.Navigator.GoGroupsPage();
            
            // check if at least one group is present
            if (app.Groups.IsGroupPresent(1))
            {
                app.Groups.Remove(1);
                return;
            }

            // action
            // else - create gpoup to delete
            GroupData group = new GroupData("created by test");
            group.Header = "hhh";
            group.Footer = "fff";

            app.Groups.Create(group);

            //delete just created group
            app.Groups.Remove(1);

            //check if no group left
            Assert.IsFalse(app.Groups.IsGroupPresent(1));
                      
        }

    }
}
