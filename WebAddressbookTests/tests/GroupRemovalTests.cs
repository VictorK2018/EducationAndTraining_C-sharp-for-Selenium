using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
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

            //get list before deleting
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            ////Zadanie #8
            //app.Groups.Remove(1);

            //delete 1-st group
            app.Groups.Remove(0);

            //get list after deleting
            List<GroupData> newGroups = app.Groups.GetGroupList();

            //delete 1-st element from old list
            oldGroups.RemoveAt(0);

            //compare lists
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
