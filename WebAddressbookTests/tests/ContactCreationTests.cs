using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {

        [Test]
        public void ContactCreationTest()
        {
            //get list before creating contact
            List<ContactData> oldContacts = app.Contacts.GetContactList();

            // action - prepare data for new contact
            app.Contacts.InitContactCreation();
            ContactData contact = new ContactData("fname9", "lname9");
            contact.Middlename = "MiddleOtchestvo9";

            // create new contact
            app.Contacts.CreateContact(contact);

            Assert.AreEqual(oldContacts.Count + 1, app.Contacts.GetContactsCount());

            //get list after creating contact
            List<ContactData> newContacts = app.Contacts.GetContactList();           

            //Adds an object to the end of the System.Collections.Generic.List`1.
            oldContacts.Add(contact);

            oldContacts.Sort();
            newContacts.Sort();

            //Console.WriteLine("Old contacts after Sort--->");
            //foreach (ContactData contactsaftersort in oldContacts)
            //{
            //    Console.WriteLine(contactsaftersort);
            //}
            Console.WriteLine("New contacts after Sort--->");
            foreach (ContactData contactsafter in newContacts)
            {
                Console.WriteLine(contactsafter);
            }

            Assert.AreEqual(oldContacts, newContacts);

            //driver.FindElement(By.LinkText("Logout")).Click();
        }

        [Test]
        public void EmptyContactCreationtest()
        {
            //get list before creating contact
            List<ContactData> oldContacts = app.Contacts.GetContactList();

            // action - prepare data for new contact
            app.Contacts.InitContactCreation();
            ContactData contact = new ContactData("", "");
            contact.Middlename = "";

            // create new contact
            app.Contacts.CreateContact(contact);

            //get list after creating contact
            List<ContactData> newContacts = app.Contacts.GetContactList();           

            //Adds an object to the end of the System.Collections.Generic.List`1.
            oldContacts.Add(contact);

            oldContacts.Sort();
            newContacts.Sort();

            Assert.AreEqual(oldContacts, newContacts);

            //driver.FindElement(By.LinkText("Logout")).Click();
        }


    }
}

