using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

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
                ContactData contact = new ContactData("firstFortest", "lastFortest");
                contact.Middlename = "OtchestvoFortest";
                app.Contacts.CreateContact(contact);
            }

            // action -prepare to modify created/existing contact
            ContactData modifContact = new ContactData("First_modifBytest", "Last_modifBytest");
            modifContact.Middlename = "Otchestvo_modif";

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            ////Zadanie #8
            //app.Contacts.ModifyContact(modifContact);

            app.Contacts.ModifyContact(0, modifContact);
            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts[0].Firstname = modifContact.Firstname;
            oldContacts[0].Lastname = modifContact.Lastname;

            oldContacts.Sort();
            newContacts.Sort();

            Assert.AreEqual(oldContacts, newContacts);

            //driver.FindElement(By.LinkText("Logout")).Click();
        }

    }
}
