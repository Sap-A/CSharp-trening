using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            OpenHomePage();
            Login(new AccountData("admin","secret"));
            GoToGroupsPage();
            InitGroupCreation();
            GroupData group = new GroupData("zzz");
            group.Header = "xxx";
            group.Footer = "ccc";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReternToGroupsPage();
            Logout();
        }   
    }
}
