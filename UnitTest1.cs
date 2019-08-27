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
            driver.Navigate().GoToUrl("http://npaee.norbit.ru:7005/Account/LogIn?sysconfig=1");
            //driver.SwitchTo().Alert().SetAuthenticationCredentials("Ruslan.Zinatov", "ZuLu3$52w#");
            //driver.SwitchTo().Alert().SendKeys("Ruslan.Zinatov" + Keys.Tab + "ZuLu3$52w#" + Keys.Tab);
            //driver.SwitchTo().Alert().Accept();
            System.Diagnostics.Process.Start("C:\\Source\\Repos\\CB_Autotest\\AutoItScript\\HandleAuthentication.exe");

            //Авторизация
            driver.FindElement(By.Id("User")).Click();
            driver.FindElement(By.Id("User")).Clear();
            driver.FindElement(By.Id("User")).SendKeys("autotest_user");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).Clear();
            driver.FindElement(By.Id("Password")).SendKeys("123");
            driver.FindElement(By.XPath("(//input[@value='Войти'])[2]")).Click();
            //Переход ЕРД
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Единый реестр договоров'])[2]/preceding::h3[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Единый реестр договоров'])[1]/following::a[1]")).Click();
            //открытие формы создания договора
            Thread.Sleep(1500);
            driver.FindElement(By.LinkText("Добавить")).Click();
            //заполнение формы создания договора 
            Thread.Sleep(100);
            driver.FindElement(By.Id("Number")).Click();
            driver.FindElement(By.Id("Number")).Clear();
            driver.FindElement(By.Id("Number")).SendKeys("Номер договора");
            driver.FindElement(By.Id("mainform")).Submit();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Дата'])[1]/following::span[4]")).Click();
            driver.FindElement(By.LinkText("11")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Способ закупки'])[1]/following::span[3]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='не задано'])[6]/following::li[1]")).Click(); Thread.Sleep(1500);
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Выберите...'])[3]/following::span[2]")).Click(); Thread.Sleep(1500);
            driver.FindElement(By.Id("responsibleSearchValue")).Click(); Thread.Sleep(1500);
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Выберите Ответственого'])[1]/following::input[1]")).Click(); Thread.Sleep(1500);
            //driver.FindElement(By.Id("responsibleSearchValue")).SendKeys("mitinas"); Thread.Sleep(1500);
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Close'])[6]/following::span[2]")).Click();
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Банк России'])[1]/following::td[1]")).Click();
            //driver.FindElement(By.Id("mainform")).Submit();
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Перечень подразделений исполнителей'])[1]/following::input[1]")).Click();
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Close'])[3]/following::span[1]")).Click();
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Департаменты'])[1]/following::span[2]")).Click();
            //driver.FindElement(By.Id("select-executing-departments")).Click();
            //driver.FindElement(By.Id("Subject")).Click();
            //driver.FindElement(By.Id("Subject")).Click();
            //driver.FindElement(By.Id("Subject")).Clear();
            //driver.FindElement(By.Id("Subject")).SendKeys("Предмет договора");
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Поставщик (исполнитель, подрядчик)'])[1]/following::span[1]")).Click();
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='КПП'])[1]/following::td[1]")).Click();
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Наименование документа'])[1]/following::span[3]")).Click();
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='не задано'])[6]/following::li[1]")).Click();
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Вид договора'])[1]/following::span[3]")).Click();
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='рамочный договор (независимо от типа договора вида работ, услуг оказанных по договору)'])[1]/following::li[1]")).Click();
            //driver.FindElement(By.Id("Signatory")).Click();
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='select'])[7]/following::span[4]")).Click();
            //driver.FindElement(By.Id("Signatory")).Clear();
            //driver.FindElement(By.Id("Signatory")).SendKeys("подписант");
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Вс'])[2]/following::a[30]")).Click();
            //driver.FindElement(By.Id("ReasonForEarlyStart")).Click();
            //driver.FindElement(By.Id("ReasonForEarlyStart")).Clear();
            //driver.FindElement(By.Id("ReasonForEarlyStart")).SendKeys("Обоснование начала работ до заключения договора");
            //driver.FindElement(By.LinkText("Далее")).Click();




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
