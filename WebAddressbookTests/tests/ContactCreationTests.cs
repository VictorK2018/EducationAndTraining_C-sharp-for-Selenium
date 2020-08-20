using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactCreationTests: AuthTestBase
    {
 
        [Test]
        public void ContactCreationTest()
        {
            //prepare data for new contact
            app.Contacts.InitContactCreation();
            ContactData contact = new ContactData("fn", "ln");
            contact.Middlename = "Otchestvo";

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.CreateContact(contact);

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.Add(contact);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);

            //driver.FindElement(By.LinkText("Logout")).Click();

        }
       
    }
}

