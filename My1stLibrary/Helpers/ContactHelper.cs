using My2ndLibrary;
using My3rdLibrary.Entities;

namespace My1stLibrary.Helpers
{
    public static class ContactHelper
    {
        public static void CreateNewContact()
        {
            var contact = new Contact();

            //contact.Id = Contact.GenerateId(contacts);

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

            var context = new DataContext();
            context.Contactes.Add(contact);
            //context.Contacts.Update(contact);
            //context.Contacts.Remove(contact);

            context.SaveChanges();

        }

        //public static List<Contact> AddContactList(List<Contact> contacts)
        //{
        //    
        //    var contact = CreateNewContact(contacts);
        //    contacts.Add(contact);
        //    return contacts;
        //}

    }
}
