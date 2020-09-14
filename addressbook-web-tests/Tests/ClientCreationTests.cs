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
            ClientData contact = new ClientData("Иван", "Тестов");

            app.Clients.Create(contact);
                
        }
        [Test]
        public void EmptyClientCreationTest()
        {
            ClientData contact = new ClientData("", "");

            app.Clients.Create(contact);

        }
    }
}
