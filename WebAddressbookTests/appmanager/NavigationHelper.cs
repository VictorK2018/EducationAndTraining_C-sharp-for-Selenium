using OpenQA.Selenium;

namespace WebAddressBookTests
{
    public class NavigationHelper : HelperBase
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
            // if this condition is valid:
            if (driver.Url == baseURL + "/addressbook")
            {
                // so, nothing to do:
                return;
            }
            driver.Navigate().GoToUrl(baseURL + "/addressbook");
        }

        public void GoGroupsPage()
        {
            // if these conditions are valid:
            if (driver.Url == baseURL + "/addressbook/group.php"
                && IsElementPresent(By.Name("new")))
            {
                // so, nothing to do:
                return;
            }
            // otherwise means we are not on the right page, so click on Groups:
            driver.FindElement(By.LinkText("groups")).Click();
        }

    }
}
