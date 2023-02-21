using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9AddressBook
{
    public class AddressBook
    {
        public List<Contacts> ContactInfo { get; set; }

        public int NumberOfContacts { get { return ContactInfo.Count; } }

        public AddressBook()
        {
            ContactInfo = new List<Contacts>();

            //NumberOfContacts = 0;
        }

        public void AddContact(Contacts contact)
        {
            ContactInfo.Add(contact);
            //ContactInfo[NumberOfContacts] = contact;
            //NumberOfContacts++;
        }


        public void PrintContacts()
        {
            foreach (Contacts contact in ContactInfo)
            {
                Console.WriteLine("Name: {0} {1}\nCountry: {2}\nPhone: {3}\nEmail: {4}\n",
                    contact.firstName, contact.lastName, contact.country, contact.phoneNumber, contact.email);
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

        public void DeleteContact(string firstName, string lastName)
        {
            for (int i = 0; i < NumberOfContacts; i++)
            {
                if (ContactInfo[i].firstName == firstName && ContactInfo[i].lastName == lastName)
                {
                    ContactInfo.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
