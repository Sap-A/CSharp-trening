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

        public ClientHelper Create(ClientData client)
        {
            InitClientCreation();
            FillClientForm(client);
            SubmitClientCreation();
            ReternToHomePage();
            
            return this;
        }

        public ClientHelper Modify(int v, ClientData newCData)
        {
            SelectContact(v);
            InitContactModification();
            FillClientForm(newCData);
            SubmitContactModification();
            return this;
        }

        public ClientHelper FillClientForm(ClientData client)
        {
            Type(By.Name("firstname"), client.FirstName);
            Type(By.Name("middlename"), client.Middlename);
            Type(By.Name("lastname"), client.LastName);
            Type(By.Name("nickname"), client.Nickname);
            Type(By.Name("title"), client.Title);
            Type(By.Name("company"), client.Company);
            Type(By.Name("address"), client.Address);
            Type(By.Name("home"), client.Home);
            Type(By.Name("mobile"), client.Mobile);
            Type(By.Name("work"), client.Work);
            Type(By.Name("fax"), client.Fax);
            Type(By.Name("email"), client.Email);
            Type(By.Name("email2"), client.Email2);
            Type(By.Name("email3"), client.Email3);
            Type(By.Name("homepage"), client.Homepage);
            TypeSelect(By.Name("bday"), client.Bday);
            TypeSelect(By.Name("bmonth"), client.Bmonth);
            Type(By.Name("byear"), client.Byear);
            TypeSelect(By.Name("aday"), client.Aday);
            TypeSelect(By.Name("amonth"), client.Amonth);
            Type(By.Name("ayear"), client.Ayear);
            Type(By.Name("address2"), client.Address2);
            Type(By.Name("phone2"), client.Phone2);
            Type(By.Name("notes"), client.Notes);
            
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

        public ClientHelper InitContactModification()
        {
            driver.FindElement(By.XPath("(//img[@alt='Edit'])[1]")).Click();
            return this;
        }
        public ClientHelper SubmitContactModification()
        {
            driver.FindElement(By.XPath("(//input[@name='update'])[2]")).Click();
            return this;
        }

        
    }
}
