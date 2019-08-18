using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class UntitledTestCase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private bool acceptNextAlert = true;


        [SetUp]
        public void SetupTest()
        {
            driver = new InternetExplorerDriver();
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("http://npaee.norbit.ru:7003/Account/LogIn?sysconfig=1");

            //driver.SwitchTo().Alert().SetAuthenticationCredentials("Ruslan.Zinatov", "ZuLu3$52w#");
            //driver.SwitchTo().Alert().SendKeys("Ruslan.Zinatov" + Keys.Tab + "ZuLu3$52w#" + Keys.Tab);
            //driver.SwitchTo().Alert().Accept();
            System.Diagnostics.Process.Start("C:\\repos\\CB\\CB_Autotest\\AutoItScript\\HandleAuthentication.exe");
            driver.FindElement(By.Id("User")).Click();
            driver.FindElement(By.Id("User")).Clear();
            driver.FindElement(By.Id("User")).SendKeys("mitinas");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).Clear();
            driver.FindElement(By.Id("Password")).SendKeys("123");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Запомнить меня'])[1]/following::input[3]")).Click();
            driver.FindElement(By.Id("ui-accordion-main-header-15")).Click();
            driver.FindElement(By.Id("ui-id-102")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
