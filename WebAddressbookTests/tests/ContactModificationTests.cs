using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressBookTests
{
    class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData modifContact = new ContactData("First_modif", "Last_modif");            
            modifContact.Middlename = "Otchestvo_modif";

            app.Contacts.ModifyContact(modifContact);            
        }
    }
}
