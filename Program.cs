namespace Day9AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AddressBook myAddressBook = new AddressBook();
            Contacts newContact = new Contacts("Prince", "Praveen", "INDIA", "8369319177", "prince.p@example.com");
            myAddressBook.AddContact(newContact);
            myAddressBook.PrintContacts();

            myAddressBook.EditContacts("Prince", "Praveen", "Prince", "Akhoury", "INDIA", "8369319188", "prince13.p@example.com");
            myAddressBook.PrintContacts();

        }
    }
}