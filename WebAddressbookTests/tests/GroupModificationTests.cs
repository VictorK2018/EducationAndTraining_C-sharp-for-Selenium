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
            if (app.Groups.IsGroupPresent(1))
            {
                GroupData newData = new GroupData("modified1Bytest");
                //newData.Header = null;
                //newData.Footer = null;
                newData.Header = "mhhh";
                newData.Footer = "mfff";

                app.Groups.Modify(1, newData);
                return;
            }

            // action
            // else - create gpoup to modify
            GroupData group = new GroupData("created by test");
            group.Header = "hhh";
            group.Footer = "fff";

            app.Groups.Create(group);            

            //modify created group
            GroupData mofifData = new GroupData("modified2Bytest");
            //newData.Header = null;
            //newData.Footer = null;
            mofifData.Header = "mhhh";
            mofifData.Footer = "mfff";

            app.Groups.Modify(1, mofifData);
        }


    }
}
