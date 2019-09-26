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
            app.Groups.Remove(1);
            //app.Navigator.GoGroupsPage();
            //app.Groups
            //    .SelectGroup(1)            
            //    .RemoveGroup()           
            //    .ReturnToGroupsPage();

            //driver.FindElement(By.LinkText("Logout")).Click();
        }
                
    }
}
