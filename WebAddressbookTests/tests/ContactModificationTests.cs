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
            if (app.Contacts.IsContactPresent())
            {
                ContactData modifContact1 = new ContactData("First_modif", "Last_modif");
                modifContact1.Middlename = "Otchestvo_modif";

                app.Contacts.ModifyContact(modifContact1);

                return;
            }

            // action -create and modify contact
            app.Contacts.InitContactCreation();
            ContactData contact = new ContactData("firstNameBytest", "lastNameBytest");
            contact.Middlename = "OtchestvoBytest";
            app.Contacts.CreateContact(contact);

            ContactData modifContact2 = new ContactData("First_modifBytest", "Last_modifBytest");            
            modifContact2.Middlename = "Otchestvo_modif";

            app.Contacts.ModifyContact(modifContact2);       
            
            // delete contact and check if deleted?

        }
    }
}
