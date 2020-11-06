using System;

namespace WebAddressBookTests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        // short record, see down:
        // private string firstname;
        // private string lastname;
        // private string middlename = "";

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
            Firstname = firstname;
            Lastname = lastname;
            // long record of this:
            //this.firstname = firstname;
            //this.lastname = lastname;
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

            return Firstname == other.Firstname & Lastname == other.Lastname;
            // long record of this:
            //return firstname == other.Firstname & lastname == other.Lastname;
        }

        public override int GetHashCode()
        {
            return Firstname.GetHashCode() & Lastname.GetHashCode();
            // long record of this:
            //return firstname.GetHashCode() & lastname.GetHashCode();
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

            else if (Lastname.CompareTo(other.Lastname) == 0)
            {
                return Firstname.CompareTo(other.Firstname);
            }

            else
            {
                return Lastname.CompareTo(other.Lastname);
            }


            // long record of this:
            //else if (lastname.CompareTo(other.lastname) == 0)
            //{
            //    return firstname.CompareTo(other.firstname);
            //}

            //else
            //{
            //    return lastname.CompareTo(other.lastname);
            //}
        }

        public string Firstname { get; set; }
        //{
        //    get
        //    {
        //        return firstname;
        //    }

        //    set
        //    {
        //        firstname = value;
        //    }
        //}
        public string Lastname { get; set; }
        //{
        //    get
        //    {
        //        return lastname;
        //    }

        //    set
        //    {
        //        lastname = value;
        //    }
        //}
        public string Middlename { get; set; }
        //{
        //    get
        //    {
        //        return middlename;
        //    }

        //    set
        //    {
        //        middlename = value;
        //    }
        //}

        public string IdCont { get; set; }
    }
}
