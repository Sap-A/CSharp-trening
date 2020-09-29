using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("qqq");
            newData.Header = "ppp";
            newData.Footer = "ooo";
            app.Groups.Modify(1, newData);
        }
    }
}
