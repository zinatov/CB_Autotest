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
    public class ApplicationManager : IDisposable
    {
        protected IWebDriver driver;
        protected NavigationHelper navigationHelper;
        protected ContractHelper contractHelper;
        protected LoginHelper loginHelper;
        protected StringBuilder verificationErrors;
        protected WebDriverWait wait;

        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        private ApplicationManager()
        {
            driver = new InternetExplorerDriver();
            verificationErrors = new StringBuilder();

            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this);
            contractHelper = new ContractHelper(this);
        }
              

        ~ApplicationManager()
        {
            Dispose();
        }

        public static ApplicationManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                ApplicationManager newInstasnce = new ApplicationManager();
                newInstasnce.Navigator.OpenAuthPage();
                app.Value = newInstasnce;
            }
            return app.Value;
        }

        public void Dispose()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }

        public NavigationHelper Navigator
        {
            get
            {
                return navigationHelper;
            }
        }

        public ContractHelper Conrtacts
        {
            get
            {
                return contractHelper;
            }
        }
     }
}