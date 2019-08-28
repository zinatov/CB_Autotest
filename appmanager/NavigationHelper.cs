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

        //Переход на рабочий стол
        public void Open_StartPage()
        {
            if (driver.Url == "http://npaee.norbit.ru:7003/Authorized")
            {
                return;
            }
            driver.Navigate().GoToUrl("http://npaee.norbit.ru:7003/Authorized");
        }
        
        //Страница авторизации
        public void OpenAuthPage()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "http://npaee.norbit.ru:7003/Account/LogIn?sysconfig=1";
        }

        //Возвращает название реестра 
        public string TitleTextFromPage()
        {
            string TitleText = driver.FindElement(By.CssSelector("h2.h4")).Text;
            return TitleText;
        }

        public void OpenProcPlanningPage()
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Реестр потребностей'])[1]/preceding::h3[1]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Реестр ГПЗ')]")).Click();
        }

        public void OpenPlanItemPage()
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Реестр потребностей'])[1]/preceding::h3[1]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Реестр лотов и ПЗ')]")).Click();
        }

        public void OpenProcInitiatingPage()
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Заявки на закупку'])[1]/preceding::h3[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Инициирование закупок'])[1]/following::a[1]")).Click();
        }

        public void OpenPurchaseInformationPage()
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Реестр закупок'])[1]/preceding::h3[1]")).Click();
            driver.FindElement(By.LinkText("Реестр закупок")).Click();
        }

        public void OpenAgreementPage()
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Единый реестр договоров'])[2]/preceding::h3[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Единый реестр договоров'])[1]/following::a[1]")).Click();
        }

        public void OpenDesirePage()
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Реестр потребностей'])[1]/preceding::h3[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='hidden'])[3]/following::a[1]")).Click();
        }


    }
}