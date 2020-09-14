using System;
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
            ClientData group = new ClientData("Иван", "Тестов");

            app.Clients.Create(group);
                
        }
    }
}
