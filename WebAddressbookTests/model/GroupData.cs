using System;

namespace WebAddressBookTests

{
    public class GroupData : IEquatable<GroupData>, IComparable<GroupData>
    {
        // for shot record these can be removed, see down in this class (see lecture 4.5):
        //private string name;
        //private string header = "";
        //private string footer = "";

        public GroupData(string name)
        {
            Name = name;
            // long record of this:
            //this.name = name;
        }

        public bool Equals(GroupData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }

            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return "name=" + Name;
        }

        public int CompareTo(GroupData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }

            return Name.CompareTo(other.Name);
        }

        //shot record (see lecture 4.5):
        public string Name { get; set; }

        // long record of this:
        //{
        //    get
        //    {
        //        return name;
        //    }

        //    set
        //    {
        //        name = value;
        //    }
        //}

        //shot record (see lecture 4.5):
        public string Header { get; set; }
        // long record of this:
        //{
        //    get
        //    {
        //        return header;
        //    }

        //    set
        //    {
        //        header = value;
        //    }
        //}

        //shot record (see lecture 4.5):
        public string Footer { get; set; }
        // long record of this:
        //{
        //    get
        //    {
        //        return footer;
        //    }

        //    set
        //    {
        //        footer = value;
        //    }
        //}

        public string Id { get; set; }
    }
}

