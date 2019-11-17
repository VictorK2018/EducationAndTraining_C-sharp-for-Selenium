using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactRemovalTests: AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            // prepare to test
            app.Navigator.GoToHomePage();

            // check if at least one contact is present
            if (app.Contacts.IsContactPresent())
            {
                app.Contacts.RemoveContact();

                return;
            }

            // action
            // else - create contact 
            app.Contacts.InitContactCreation();
            ContactData contact = new ContactData("firstNameBytest", "lastNameBytest");
            contact.Middlename = "OtchestvoBytest";
            app.Contacts.CreateContact(contact);            

            //delete created contact
            app.Contacts.RemoveContact();

            //app.Navigator.GoGroupsPage();
            //app.Navigator.GoToHomePage();

            //check if no contact left
            Assert.IsFalse(app.Contacts.IsContactPresent());

        }

    }
}
