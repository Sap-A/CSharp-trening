﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ClientCreationTests : TestBase
    {
        [Test]
        public void ClientCreationTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            InitClientCreation();
            ClientData group = new ClientData("Иван", "Тестов");
            FillClientForm(group);
            SubmitClientCreation();
            ReternToHomePage();
            Logout();
        }
    }
}
