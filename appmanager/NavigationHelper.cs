using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace CB_Autotest
{
    public class NavigationHelper : HelperBase
    {
        public NavigationHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void Open_StartPage()
        {
            if (driver.Url == "http://npaee.norbit.ru:7003/Authorized")
            {
                return;
            }
            driver.Navigate().GoToUrl("http://npaee.norbit.ru:7003/Authorized");
        }

        public void GoToAgreement()
        {
            if (driver.Url == "http://npaee.norbit.ru:7003/Agreement/AgreementRegister")//&& IsElementPresent(By.Name("new")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }

        public void GoToAuthPage()
        {
            driver.Url = "http://npaee.norbit.ru:7003/Account/LogIn?sysconfig=1";
        }

    }
}