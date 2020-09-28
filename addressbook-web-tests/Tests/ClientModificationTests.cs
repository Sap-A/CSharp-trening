using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ClientModificationTests : TestBase
    {
        [Test]
        public void ClientModificationTest()
        {
            ClientData newCData = new ClientData("Владимир", "Измененный");
            newCData.Middlename = "Валентинович";
            newCData.Nickname = "QС";
            newCData.Title = "TitleN";
            newCData.Company = "CompanyN";
            newCData.Address = "Москва-2";
            newCData.Home = "3";
            newCData.Mobile = "+700000002";
            newCData.Work = "8095";
            newCData.Fax = "+";
            newCData.Email = "1test@test.ts";
            newCData.Email2 = "1test2@test.ts";
            newCData.Email3 = "1test3@test.ts";
            newCData.Homepage = "Homepage2";
            newCData.Bday = "3";
            newCData.Bmonth = "November";
            newCData.Byear = "1917";
            newCData.Aday = "11";
            newCData.Amonth = "March";
            newCData.Ayear = "2011";
            newCData.Address2 = "1Address2";
            newCData.Phone2 = "Phone2";
            newCData.Notes = "Заметка другая";
            app.Clients.Modify(1, newCData);
        }
    }
}
