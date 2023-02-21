namespace Day9AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {

            AddressBook myAddressBook = new AddressBook();

            Contacts newContact = new Contacts("Prince", "Praveen", "INDIA", "8369319177", "prince.p@example.com");
            myAddressBook.AddContact(newContact);

            Contacts newContact1 = new Contacts("Piyush", "Akhoury", "INDIA", "8879393114", "piyush.p@example.com");
            myAddressBook.AddContact(newContact1);

            Contacts newContact2 = new Contacts("Tony", "Stark", "USA", "8885550000", "tony.stark@tech.com");
            myAddressBook.AddContact(newContact2);

            myAddressBook.PrintContacts();
            


        }
    }
}