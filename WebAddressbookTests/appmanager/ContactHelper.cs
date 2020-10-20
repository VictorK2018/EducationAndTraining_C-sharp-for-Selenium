using OpenQA.Selenium;
using System;
using System.Collections.Generic;


namespace WebAddressBookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager)
            : base(manager)
        {

        }
        public ContactHelper CreateContact(ContactData contact)
        {
            FillContactForm(contact);
            SubmitContactForm();
            ReturnToHomePage();
            return this;
        }
        public ContactHelper ModifyContact(ContactData modifContact)
        {
            manager.Navigator.GoToHomePage();
            SelectContact();
            FillContactForm(modifContact);
            SubmitModifiedContact();
            ReturnToHomePage();

            return this;
        }
        public ContactHelper RemoveContact()
        {
            manager.Navigator.GoToHomePage();
            SelectDeleteContact();
            DeleteContact();
            //ReturnToHomePage();                        
            driver.FindElement(By.CssSelector("div.msgbox"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            return this;
        }
        public ContactHelper ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
            return this;
        }
        public ContactHelper SubmitContactForm()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
            return this;
        }
        public ContactHelper FillContactForm(ContactData contact)
        {
            //WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            //driver.FindElement(By.Name("firstname")).Click();
            //driver.FindElement(By.Name("firstname")).Clear();
            Type(By.Name("firstname"), contact.Firstname);
            //driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);

            //driver.FindElement(By.Name("lastname")).Click();
            //driver.FindElement(By.Name("lastname")).Clear();
            Type(By.Name("lastname"), contact.Lastname);
            //driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);

            //driver.FindElement(By.Name("middlename")).Click();
            //driver.FindElement(By.Name("middlename")).Clear();
            Type(By.Name("middlename"), contact.Middlename);
            //driver.FindElement(By.Name("middlename")).SendKeys(contact.Middlename);

            return this;
        }
        public ContactHelper InitContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
        public ContactHelper SelectContact()
        {
            // select 1-st contact to Edit/Modify
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            return this;
        }
        public ContactHelper SubmitModifiedContact()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public ContactHelper SelectDeleteContact()
        {
            // select 1-st contact to Delete
            driver.FindElement(By.Name("selected[]")).Click();
            return this;
        }
        public ContactHelper DeleteContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        public bool IsContactPresent()
        {
            return IsElementPresent(By.Name("selected[]"));
        }

        public List<ContactData> GetContactList()
        {
            List<ContactData> contacts = new List<ContactData>();
            manager.Navigator.GoToHomePage();
            //Задание 8
            //ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("td:nth-of-type(2)"));

            ICollection<IWebElement> elements = driver.FindElements(By.CssSelector(("tr[name=entry] > td:nth-of-type(3)","tr[name=entry] > td:nth-of-type(2)")));

            //foreach (IWebElement element in elements)
            //{
            //    contacts.Add(new ContactData(element.Text));
            //    //contacts.Add(new ContactData(string.Format(element.Text)));
            //}

            //return contacts;

            foreach (IWebElement element in elements)
            {
                //contacts.Add(new ContactData("", element.Text));
                contacts.Add(new ContactData(element.Text, element.Text));

                Console.WriteLine(element.Text, element.Text);

            }

            Console.WriteLine("______");

            return contacts;
        }

    }
}
