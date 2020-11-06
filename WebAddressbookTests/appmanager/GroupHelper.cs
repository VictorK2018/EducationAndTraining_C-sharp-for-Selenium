using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace WebAddressBookTests
{
    public class GroupHelper : HelperBase
    {
        //private IWebDriver driver;
        public GroupHelper(ApplicationManager manager)
            : base(manager)
        {

        }

        public GroupHelper Create(GroupData group)
        {
            manager.Navigator.GoGroupsPage();

            InitGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            return this;
        }
        public GroupHelper Modify(int p, GroupData newData)
        {
            manager.Navigator.GoGroupsPage();
            SelectGroup(p);
            InitGroupModification();
            FillGroupForm(newData);
            SubmitGroupModification();
            ReturnToGroupsPage();

            return this;
        }

        public GroupHelper Remove(int p)
        {
            manager.Navigator.GoGroupsPage();
            SelectGroup(p);
            RemoveGroup();
            ReturnToGroupsPage();

            return this;
        }
        public GroupHelper InitGroupCreation()
        {
            // init new group
            driver.FindElement(By.Name("new")).Click();
            return this;
        }
        public GroupHelper FillGroupForm(GroupData group)
        {
            Type(By.Name("group_name"), group.Name);
            //driver.FindElement(By.Name("group_header")).Click();
            Type(By.Name("group_header"), group.Header);
            //driver.FindElement(By.Name("group_footer")).Click();
            Type(By.Name("group_footer"), group.Footer);

            return this;
        }
        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            groupCash = null;
            return this;
        }
        public GroupHelper ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }
        public GroupHelper SelectGroup(int index)
        {
            // add "1" to index - be equal to Collection numeration (starting from "0")
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index + 1) + "]")).Click();

            // takes all XPath ...selected[index]...  
            //driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();

            // for Zadanie #8:
            //driver.FindElement(By.CssSelector("input[name=\"selected[]\"]")).Click();

            return this;
        }
        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            groupCash = null;
            return this;
        }
        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }
        public GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            groupCash = null;
            return this;
        }

        public bool IsGroupPresent(int index)
        {
            // add "1" to index - be equal to Collection numeration (starting from "0")
            return IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + (index + 1) + "]"));

            ////Zadanie #8
            //return IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + index + "]"));
        }

        private List<GroupData> groupCash = null;

        public List<GroupData> GetGroupList()
        {
            if  (groupCash == null)
            {
                groupCash = new List<GroupData>();
                manager.Navigator.GoGroupsPage();
                ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group"));
                foreach (IWebElement element in elements)
                {
                    //long record:
                    //GroupData group = new GroupData(element.Text) {
                    //    Id = element.FindElement(By.TagName("input")).GetAttribute("value")
                    //    };                    
                    //groupCash.Add(group);

                    groupCash.Add(new GroupData(element.Text) {
                        Id = element.FindElement(By.TagName("input")).GetAttribute("value")
                    });
                }
            }

            return new List<GroupData>(groupCash);
        }
        public int GetGroupCount()
        {
            return driver.FindElements(By.CssSelector("span.group")).Count;
        }

    }
}
