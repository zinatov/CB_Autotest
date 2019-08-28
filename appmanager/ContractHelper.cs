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

        public void OpenAgreementPage()
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Единый реестр договоров'])[2]/preceding::h3[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Единый реестр договоров'])[1]/following::a[1]")).Click();
        }
      
    }
}