using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace WebAddressBookTests
{
    public class ContactHelper: HelperBase
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
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
            driver.FindElement(By.Name("middlename")).Click();
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(contact.Middlename);
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


    }
}
