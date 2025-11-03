using My1stLibrary.Helpers;
using My1stLibrary.Models;
using My2ndLibrary;
using My3rdLibrary.Entities;

bool running = true;

var context = new DataContext();

var contacts = context.Contactes.ToList(); //new List<Contact>();

while (running)
{

    Console.WriteLine("Please chose an option");
    Console.WriteLine("1. Add, 2. Edit, 3. View All, 4. Search, 5. Delete 6. Exit");

    var chosenOption = int.Parse(Console.ReadLine());

    switch (chosenOption)
    {
        case 1:
            ContactHelper.CreateNewContact();
            break;
        case 3:
            ShowAllContacts();
            break;
        case 4:
            {
                Console.WriteLine("Please choose an search option");
                Console.WriteLine("1. Id, 2. Search Criterial (Name, Email, Lastname)");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.WriteLine("Please type an Id");
                            var typedId = int.Parse(Console.ReadLine());

                            PrintHeader();
                            var contact = contacts.FirstOrDefault(p => p.Id == typedId);
                            if (contact != null)
                            {
                                Console.WriteLine($"{contact.Id}     {contact.Name}        {contact.LastName}      {contact.Address}      {contact.Email}    {contact.Age}       {(contact.IsFavorite == true ? "Yes" : "No")}");
                            }
                            else
                            {
                                Console.WriteLine("Contact Not Found");
                            }
                        }
                        break;
                    case "2":
                        {
                            Console.WriteLine("Please type a criteria");
                            var searchCriterial = Console.ReadLine();

                            PrintHeader();


                            var contactsFiltered = contacts.Where(p => p.Name.ToLower().Contains(searchCriterial.ToLower()));
                            contactsFiltered = contactsFiltered.Where(p => p.LastName.ToLower().Contains(searchCriterial.ToLower()));

                            if (searchCriterial.Contains("@"))
                            {
                                contactsFiltered = contactsFiltered.Where(p => p.Email.ToLower().Contains(searchCriterial.ToLower()));
                            }

                            var test1 = contactsFiltered.FirstOrDefault(p => p.Id == 1);
                            var test11 = contactsFiltered.First(p => p.Id == 1);

                            var test111 = contactsFiltered.Single(p => p.Id == 1);
                            var test1111 = contactsFiltered.SingleOrDefault(p => p.Id == 1);

                            var favoritesAndgreaterAge = contactsFiltered
                                .Where(p => p.Age >= 18 && p.IsFavorite).ToList();

                            var favoritesAndgreaterAge2 = (from Contact contact in contactsFiltered
                                                           where contact.Age >= 18 && contact.IsFavorite
                                                           select contact).ToList();

                            var favoritesCotnacts = new List<ContactFavorites>();


                            var temp = favoritesAndgreaterAge2.Select(p => new ContactFavorites
                            {
                                BestFriendName = p.Name + " " + p.LastName,
                            }).ToList();

                            foreach (var contact in contactsFiltered)
                            {
                                Console.WriteLine($"{contact.Id}     {contact.Name}        {contact.LastName}      {contact.Address}      {contact.Email}    {contact.Age}       {(contact.IsFavorite == true ? "Yes" : "No")}");
                            }
                        }
                        break;
                    default:
                        break;

                }

            }
            break;
        case 6:
            running = false;
            break;
        default:
            break;
    }

}

void PrintHeader()
{
    Console.WriteLine("ID       Name        LastName        Address     Email       Age     Is Favorite");

}
void ShowAllContacts()
{
    PrintHeader();

    foreach (var contact in contacts)
    {
        Console.WriteLine($"{contact.Id}     {contact.Name}        {contact.LastName}      {contact.Address}      {contact.Email}    {contact.Age}       {(contact.IsFavorite == true ? "Yes" : "No")}");
    }
}

