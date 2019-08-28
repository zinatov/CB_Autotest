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
    public class NavigationTests : AuthTestBase
    {
        
        [Test]
        public void OpenDesirePageTest()
        {   //Проверка открытия реестра потреностей
            app.Navigator.OpenDesirePage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Реестр потребностей");
        }


        [Test]
        public void OpenAgreementPageTest()
        {   //Проверка открытия ЕРД
            app.Navigator.OpenAgreementPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Единый реестр договоров");
        }

        [Test]
        public void OpenPlanItemPageTest()
        {   //Проверка открытия реестра лотов и ПЗ
            app.Navigator.OpenPlanItemPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Реестр лотов и ПЗ");
        }

        [Test]
        public void OpenProcPlanningPageTest()
        {   //Проверка открытия реестра ГПЗ
            app.Navigator.OpenProcPlanningPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Реестр годовых планов закупок");
        }

        //Название реестра в другом локаторе, нужно доработать
        //[Test]
        //public void OpenProcInitiatingPageTest()
        //{   //Проверка открытия реестра ЗНЗ
        //    app.Navigator.OpenProcInitiatingPage();
        //    Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Заявки на закупку");
        //}

        [Test]
        public void OpenPurchaseInformationPageTest()
        {   //Проверка открытия реестра ЗНЗ
            app.Navigator.OpenPurchaseInformationPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Реестр закупок");
        }
    }
}