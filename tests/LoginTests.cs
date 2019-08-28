﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NUnit.Framework;

namespace CB_Autotest
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            //prepare
            app.Navigator.OpenAuthPage();

            // action
            AccountData account = new AccountData("autotest_user", "123");
            app.Auth.Login(account);

            // verification
            Assert.IsTrue(app.Auth.IsLoggedIn());
        }

        [Test]
        public void LoginWithInvalidCredentials()
        {
            //prepare
            app.Auth.LogOut();
            // action
            AccountData account = new AccountData("admin", "1234565");
            app.Auth.Login(account);

            // verification
            Assert.IsFalse(app.Auth.IsLoggedIn());
        }
    }
}