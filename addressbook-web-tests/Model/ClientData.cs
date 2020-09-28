using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ClientData
    {
        private string firstName;
        private string lastName;
        private string middleName = "";
        private string nickName = "";
        private string title = "";
        private string company = "";
        private string address = "";
        private string home = "";
        private string mobile = "";
        private string work = "";
        private string fax = "";
        private string email = "";
        private string email2 = "";
        private string email3 = "";
        private string homePage = "";
        private string bDay = "";
        private string bMonth = "";
        private string bYear = "";
        private string aDay = "";
        private string aMonth = "";
        private string aYear = "";
        private string address2 = "";
        private string phone2 = "";
        private string notes = "";

        public ClientData(string firstName, string lastName) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Middlename
        {
            get
            {
                return middleName;
            }
            set
            {
                middleName = value;
            }
      
        }
        public string Nickname
        {
            get
            {
                return nickName;
            }
            set
            {
                nickName = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string Home
        {
            get
            {
                return home;
            }
            set
            {
                home = value;
            }
        }
        public string Mobile
        {
            get
            {
                return mobile;
            }
            set
            {
                mobile = value;
            }
        }
        public string Work
        {
            get
            {
                return work;
            }
            set
            {
                work = value;
            }
        }
        public string Fax
        {
            get
            {
                return fax;
            }
            set
            {
                fax = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Email2
        {
            get
            {
                return email2;
            }
            set
            {
                email2 = value;
            }
        }
        public string Email3
        {
            get
            {
                return email3;
            }
            set
            {
                email3 = value;
            }
        }
        public string Homepage
        {
            get
            {
                return homePage;
            }
            set
            {
                homePage = value;
            }
        }
        public string Bday
        {
            get
            {
                return bDay;
            }
            set
            {
                bDay = value;
            }
        }
        public string Bmonth
        {
            get
            {
                return bMonth;
            }
            set
            {
                bMonth = value;
            }
        }
        public string Byear
        {
            get
            {
                return bYear;
            }
            set
            {
                bYear = value;
            }
        }

        public string Aday
        {
            get
            {
                return aDay;
            }
            set
            {
                aDay = value;
            }
        }
        public string Amonth
        {
            get
            {
                return aMonth;
            }
            set
            {
                aMonth = value;
            }
        }
        public string Ayear
        {
            get
            {
                return aYear;
            }
            set
            {
                aYear = value;
            }
        }
        public string Address2
        {
            get
            {
                return address2;
            }
            set
            {
                address2 = value;
            }
        }
        public string Phone2
        {
            get
            {
                return phone2;
            }
            set
            {
                phone2 = value;
            }
        }
        public string Notes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
            }
        }

    }
}
