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
            GroupData newData = new GroupData("mmm");
            newData.Header = null;
            newData.Footer = null;
            //newData.Header = "mhhh";
            //newData.Footer = "mfff";

            app.Groups.Modify(1, newData);
        }


    }
}
