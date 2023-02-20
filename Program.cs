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
        }
    }
}