using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    public class ContactData
    {
        private string firstname;
        private string lastname;
        private string middlename = "";
        //private string nickname = "";
        //private string photo = "";
        //private string title = "";
        //private string company = "";
        //private string address = "";
        //private string homephone = "";
        //private string mobilephone = "";
        //private string workphone = "";
        //private string fax = "";
        //private string email = "";
        //private string email2 = "";
        //private string email3 = "";
        //private string contacthomepage = "";
        //private string birthday = "";
        //private string anniversary = "";
        //private string contactgroup = "";
        //private string secondaryaddress = "";
        //private string secondaryhome = "";
        //private string notes = "";

        public ContactData(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public string Middlename
        {
            get
            {
                return middlename;
            }

            set
            {
                middlename = value;
            }
        }

    }
}
