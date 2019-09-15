﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressBookTests
{
    public class NavigationHelper: HelperBase
    {
        //private IWebDriver driver;
        private string baseURL;
        public NavigationHelper(ApplicationManager manager, string baseURL)
            : base(manager)
        {            
            this.baseURL = baseURL;
        }
        public void GoToHomePage()
        {
            // driver.Navigate().GoToUrl(baseURL + "/addressbook/group.php");
            driver.Navigate().GoToUrl(baseURL + "/addressbook");
        }

        public void GoGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
               
    }
}