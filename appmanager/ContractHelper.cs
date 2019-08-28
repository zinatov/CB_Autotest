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
    public class ContractHelper : HelperBase
    {
        public ContractHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void ContractCreation()
        {
            
            OpenContractCreateForm();
            FillFormOnFirstTab();
            OpenSecondTab();

        }

        private void OpenSecondTab()
        {
            driver.FindElement(By.LinkText("Далее")).Click();
        }

        private void NewMethod()
        {
            driver.FindElement(By.LinkText("Далее")).Click();
        }

        private void FillFormOnFirstTab()
        {
            driver.FindElement(By.Id("Number")).Click();
            driver.FindElement(By.Id("Number")).Clear();
            driver.FindElement(By.Id("Number")).SendKeys("Номер договора");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Дата'])[1]/following::span[4]")).Click();
            driver.FindElement(By.LinkText("28")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Способ закупки'])[1]/following::span[3]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='не задано'])[6]/following::li[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Ответственный за договор'])[1]/following::span[1]")).Click();
            driver.FindElement(By.Id("responsibleSearchValue")).Click();
            driver.FindElement(By.Id("responsibleSearchValue")).Clear();
            driver.FindElement(By.Id("responsibleSearchValue")).SendKeys("autotest");
            driver.FindElement(By.Id("responsibleSearchValue")).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Фамилия_тест Имя_тест Отчество_тест'])[1]/following::td[2]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Перечень подразделений исполнителей'])[1]/following::input[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Close'])[3]/following::span[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Департаменты'])[1]/following::span[2]")).Click();
            driver.FindElement(By.Id("select-executing-departments")).Click();
            driver.FindElement(By.Id("Subject")).Click();
            driver.FindElement(By.Id("Subject")).Clear();
            driver.FindElement(By.Id("Subject")).SendKeys("Предмет договора");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Поставщик (исполнитель, подрядчик)'])[1]/following::span[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='КПП'])[1]/following::td[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Наименование документа'])[1]/following::span[3]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='не задано'])[6]/following::li[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Вид договора'])[1]/following::span[3]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='не задано'])[6]/following::li[1]")).Click();
            driver.FindElement(By.Id("Signatory")).Click();
            driver.FindElement(By.Id("Signatory")).Clear();
            driver.FindElement(By.Id("Signatory")).SendKeys("Подписант");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='select'])[7]/following::span[4]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Вс'])[2]/following::a[31]")).Click();
        }

        private void OpenContractCreateForm()
        {
            driver.FindElement(By.LinkText("Добавить")).Click();
        }
    }
}