using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9AddressBook
{
    public class AddressBook
    {
        public Contacts[] ContactInfo { get; set; }
        public int NumberOfContacts { get; set; }

        public AddressBook()
        {
            ContactInfo = new Contacts[100];
            NumberOfContacts = 0;
        }

        public void AddContact(Contacts contact)
        {
            ContactInfo[NumberOfContacts] = contact;
            NumberOfContacts++;
        }


        public void PrintContacts()
        {
            for (int i = 0; i < NumberOfContacts; i++)
            {
                Console.WriteLine("Name: {0} {1}\nCountry: {2}\nPhone: {3}\nEmail: {4}\n",
                    ContactInfo[i].firstName, ContactInfo[i].lastName, ContactInfo[i].country, ContactInfo[i].phoneNumber, ContactInfo[i].email);
            }
        }

        public void EditContacts(string firstName, string lastName, string newFirstName, string newLastName, string country, string phoneNumber, string email)
        {
            for (int i = 0; i < NumberOfContacts; i++)
            {
                if (ContactInfo[i].firstName == firstName && ContactInfo[i].lastName == lastName)
                {
                    ContactInfo[i].firstName = newFirstName;
                    ContactInfo[i].lastName = newLastName;
                    ContactInfo[i].country = country;
                    ContactInfo[i].phoneNumber = phoneNumber;
                    ContactInfo[i].email = email;
                }
            }
        }
    }
}
