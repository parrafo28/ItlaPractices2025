using My6thProgram.Models;

namespace My6thProgram.Helpers
{
    public static class ContactHelper
    {
        // public static List<Contact> CreateNewContact(List<Contact> contacts)
        public static Contact CreateNewContact(List<Contact> contacts)
        {
            var contact = new Contact();

            contact.Id = Contact.GenerateId(contacts);

            Console.WriteLine("Type a name");
            contact.Name = Console.ReadLine();

            Console.WriteLine("Type a lastname");
            var lastname = Console.ReadLine();
            contact.LastName = lastname;

            Console.WriteLine("Type an address");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Type a email");
            contact.Email = Console.ReadLine();

            Console.WriteLine("Type an age");
            contact.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Type a Phone Number");
            contact.Phone = Console.ReadLine();

            Console.WriteLine("Is favorite Contact? 1. Yes, 2. No");
            contact.IsFavorite = Console.ReadLine() == "1" ? true : false;

            return contact;
        }

        public static List<Contact> AddContactList(List<Contact> contacts)
        {
            var contact = CreateNewContact(contacts);
            contacts.Add(contact);
            return contacts;
        }

        //public static void AddContactList(List<Contact> contacts)
        //{
        //    var contact = CreateNewContact(contacts);
        //    contacts.Add(contact);
        //}
    }
}
