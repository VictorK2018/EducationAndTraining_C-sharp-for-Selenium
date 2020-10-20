using NUnit.Framework;
using System.Collections.Generic;


namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
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

            //get old list before deleting
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            //delete created/existing group
            app.Groups.Remove(0);

            //get new list after deleting
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);

        }

        //// zadanie #8:
        //[Test]
        //public void GroupRemovalTest()
        //{
        //    // prepare to test
        //    app.Navigator.GoGroupsPage();

        //    // check if at least one group is present
        //    if (!app.Groups.IsGroupPresent(1))
        //    {
        //        // action - create group to delete
        //        GroupData group = new GroupData("created by test");
        //        group.Header = "hhh";
        //        group.Footer = "fff";

        //        app.Groups.Create(group);
        //    }                     

        //    //delete created/existing group
        //    app.Groups.Remove(1);

        //    //check if no group left
        //    Assert.IsFalse(app.Groups.IsGroupPresent(1));

        //}

    }
}
