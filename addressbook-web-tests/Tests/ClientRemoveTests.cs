using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ClientRemoveTests : TestBase
    {
        [Test]
        public void ClientRemoveTest()
        {
            app.Clients.Remove(1);
        }
    }
}

