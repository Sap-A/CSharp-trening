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
            ClientData client = new ClientData("Иван", "Тестов");
            client.Middlename = "Олегович";
            client.Nickname = "QAvakado";
            client.Title = "Title";
            client.Company = "Company";
            client.Address = "Москва";
            client.Home = "1";
            client.Mobile = "+700000000";
            client.Work = "8495";
            client.Fax = "-";
            client.Email = "test@test.ts";
            client.Email2 = "test2@test.ts";
            client.Email3 = "test3@test.ts";
            client.Homepage = "Homepage";
            client.Bday = "7";
            client.Bmonth = "November";
            client.Byear = "1917";
            client.Aday = "8";
            client.Amonth = "March";
            client.Ayear = "2011";
            client.Address2 = "Address2";
            client.Phone2 = "Phone2";
            client.Notes = "Заметка";

            app.Clients.Create(client);
                
        }
        [Test]
        public void EmptyClientCreationTest()
        {
            ClientData client = new ClientData("", "");            
            client.Bday = null;
            client.Bmonth = null;            
            client.Aday = null;
            client.Amonth = null;          

            app.Clients.Create(client);

        }
    }
}
