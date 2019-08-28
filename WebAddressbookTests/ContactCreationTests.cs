using System;
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
    public class ContactCreationTests: TestBase
    {

        [Test]
        public void ContactCreationTest()
        {
            GoToHomePage();
            Login(new AccountData ("admin", "secret"));
            InitContactCreation();
            ContactData contact = new ContactData("fn", "ln");
            contact.Middlename = "Otchestvo";
            FillContactForm(contact);
            SumbitContactForm();
            ReturnToHomePage();

            //driver.FindElement(By.LinkText("Logout")).Click();
        }
 

    }
}

