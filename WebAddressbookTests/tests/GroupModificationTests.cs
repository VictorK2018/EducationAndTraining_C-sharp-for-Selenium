using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
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
                GroupData group = new GroupData("created for modification");
                group.Header = "hhh";
                group.Footer = "fff";

                app.Groups.Create(group);
            }

            // action - prepare to modify created/existing group
            GroupData newData = new GroupData("mmm");
            newData.Header = null;
            newData.Footer = null;

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            GroupData oldData = oldGroups[0];

            ////Zadanie #8
            //app.Groups.Modify(1, newData);

            app.Groups.Modify(0, newData);

            //perform quick check
            Assert.AreEqual(oldGroups.Count, app.Groups.GetGroupCount());

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[0].Name = newData.Name;

            oldGroups.Sort();
            newGroups.Sort();
            //Console.WriteLine("Old groups AFTER sorting--->");
            //foreach (GroupData befsort in oldGroups)
            //{
            //    Console.WriteLine(befsort);
            //}
            Assert.AreEqual(oldGroups, newGroups);

            foreach (GroupData group in newGroups)
            {
                if (group.Id == oldData.Id)
                {
                    Assert.AreEqual(newData.Name, group.Name);
                }
            }

        }

    }
}
