

using My1stLibrary.Helpers;
using My1stLibrary.Models;

bool running = true;
int currentId = 0;


var contacts = new List<Contact>();


//var contact = new My6thProgram.Models.Contact();
//contact.CreateContact("", "");

//var contact2 = new My6thProgram.Models.Contact().CreateContact2("", "");

//contact.Name = "a Name";

//list.Add(contact);
//foreach (var item in list)
//{

//    Console.WriteLine($"The name is: {contact.Name}");
//    Console.WriteLine($"The name is: {contact.LastName}");

//}

while (running) //(++currentId++ > 5)
{


    Console.WriteLine("Please chose an option");
    Console.WriteLine("1. Add, 2. Edit, 3. View All, 4. Search, 5. Delete 6. Exit");

    var chosenOption = int.Parse(Console.ReadLine());

    switch (chosenOption)
    {
        case 1: //adding contacts 
            //ContactHelper.AddContactList(contacts);
            contacts = ContactHelper.AddContactList(contacts);
            break;
        case 3:
            ShowAllContacts();
            break;
        case 4:
            {
                Console.WriteLine("Please choose an search option");
                Console.WriteLine("1. Id, 2. Name, 3. Lastname");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.WriteLine("Please type an Id");
                            var typedId = int.Parse(Console.ReadLine());

                            PrintHeader();
                            // var contact = contacts.Find(p=> p.Id == typedId);
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
                            Console.WriteLine("Please type the name");
                            var name = Console.ReadLine();

                            PrintHeader();

                            var contactsFiltered = contacts.Where(p => p.Name.ToLower().Contains(name.ToLower()));
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
    //for (int i = 0; i < names.Count; i++)
    //{
    //    var id = i + 1;
    //    Console.WriteLine($"{id}     {names[id]}        {lastnames[id]}      {addresses[id]}      {emails[id]}    {ages[id]}       {(favorites[id] ? "Yes" : "No")}");
    //}
    foreach (var contact in contacts)
    {
        Console.WriteLine($"{contact.Id}     {contact.Name}        {contact.LastName}      {contact.Address}      {contact.Email}    {contact.Age}       {(contact.IsFavorite == true ? "Yes" : "No")}");
    }
}

