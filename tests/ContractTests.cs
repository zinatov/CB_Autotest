using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace CB_Autotest
{
    [TestFixture]
    public class AgreementTests : AuthTestBase
    {
        [Test]
        public void ContractCreationTest()
        {
            app.Navigator.OpenAgreementPage();
            app.Conrtacts.ContractCreation();
        }
    }
}