using System;

namespace WebAddressBookTests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
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

        //constructor
        public ContactData(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }

            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            // The & operator computes the logical AND of its operands. 
            // The result of x & y is true if both x and y evaluate to true. 
            // Otherwise, the result is false.

            return firstname == other.Firstname & lastname == other.Lastname;
        }

        public override int GetHashCode()
        {
            return firstname.GetHashCode() & lastname.GetHashCode();
        }

        public override string ToString()
        {
            return "firstname= " + Firstname + ", " + "lastname= " + Lastname;
        }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }

            else if (firstname.CompareTo(other.firstname) == 0)
            {
                return lastname.CompareTo(other.lastname);
            }

            else
            {
                return firstname.CompareTo(other.firstname);
            }

            //if (Object.ReferenceEquals(other, null))
            //{
            //    return 1;
            //}
            //return Firstname.CompareTo(other.Firstname) & Lastname.CompareTo(other.Lastname);   
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
