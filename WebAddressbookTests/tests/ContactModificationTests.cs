using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressBookTests
{
    class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            // prepare to test
            app.Navigator.GoToHomePage();

            // check if at least one contact is present
            if (!app.Contacts.IsContactPresent())
            {
                // action - create contact for modification
                app.Contacts.InitContactCreation();
                ContactData contact = new ContactData("firstNameBytest", "lastNameBytest");
                contact.Middlename = "OtchestvoBytest";
                app.Contacts.CreateContact(contact);
            }

            // action -modify created/existing contact
            ContactData modifContact = new ContactData("First_modifBytest", "Last_modifBytest");            
            modifContact.Middlename = "Otchestvo_modif";

            app.Contacts.ModifyContact(modifContact);     

        }

    }
}
