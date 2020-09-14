using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ClientHelper : HelperBase
    { 
        public ClientHelper(ApplicationManager manager) : base(manager)
        {
        }
        public ClientHelper InitClientCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public ClientHelper Create(ClientData group)
        {
            InitClientCreation();
            FillClientForm(group);
            SubmitClientCreation();
            ReternToHomePage();
            
            return this;
        }

        public ClientHelper FillClientForm(ClientData group)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(group.FirstName);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(group.LastName);
            return this;
        }

        public ClientHelper SubmitClientCreation()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
            return this;
        }
        public ClientHelper ReternToHomePage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
            return this;
        }
    }
}
