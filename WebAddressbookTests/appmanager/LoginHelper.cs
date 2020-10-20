using OpenQA.Selenium;
using System;

namespace WebAddressBookTests
{
    public class LoginHelper : HelperBase
    {
        //private IWebDriver driver;
        public LoginHelper(ApplicationManager manager)
            : base(manager)
        {

        }

        public void Login(AccountData account)
        {
            // we are logged in?
            if (IsLoggedIn())
            {
                // we are logged in with rigth credentials?
                if (IsLoggedIn(account))
                {
                    return;
                }

                Logout();
            }

            // set waiting
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            //driver.FindElement(By.Name("user")).Click();
            Type(By.Name("user"), account.Username);
            //driver.FindElement(By.Name("pass")).Click();
            Type(By.Name("pass"), account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }

        public void Logout()
        {
            if (IsLoggedIn())
            {
                driver.FindElement(By.LinkText("Logout")).Click();

                //set delay after Logout
                driver.FindElement(By.Name("user"));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            }
        }
        public bool IsLoggedIn()
        {
            return IsElementPresent(By.Name("logout"));
        }
        public bool IsLoggedIn(AccountData account)
        {
            return IsLoggedIn()
                && driver.FindElement(By.Name("logout")).FindElement(By.TagName("b")).Text
                == "(" + account.Username + ")";
        }

    }
}
