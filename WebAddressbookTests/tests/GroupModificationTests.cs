using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupModificationTests: AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            // prepare to test
            app.Navigator.GoGroupsPage();

            // check if at least one group is present
            if (!app.Groups.IsGroupPresent(1))
            {
                // action - create group to modify
                GroupData group = new GroupData("created by test");
                group.Header = "hhh";
                group.Footer = "fff";

                app.Groups.Create(group);
            }

            // action modify created/existing group
            GroupData newData = new GroupData("mmm");
            newData.Header = null;
            newData.Footer = null;

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            ////Zadanie #8
            //app.Groups.Modify(1, newData);

            app.Groups.Modify(0, newData);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }


    }
}
