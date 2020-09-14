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

        public ClientHelper Remove(int v)
        {
            SelectContact(v);
            RemoveClient();
            return this;
        }

        public ClientHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }
        public ClientHelper RemoveClient()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            driver.SwitchTo().Alert().Accept(); ; 
            return this;
        }
        public ClientHelper InitClientCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public ClientHelper Create(ClientData contact)
        {
            InitClientCreation();
            FillClientForm(contact);
            SubmitClientCreation();
            ReternToHomePage();
            
            return this;
        }

        public ClientHelper FillClientForm(ClientData contact)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.FirstName);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.LastName);
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
