using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemoveTests : TestBase 
    {       
        [Test]
        public void TheUntitledTestCaseTest()
        {
            app.Groups.Remove(1);
        }
    }
}
