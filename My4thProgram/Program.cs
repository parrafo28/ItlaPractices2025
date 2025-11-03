
//public class Program {

//    public static void Main(string[] args)
//    { 
//key:value
bool running = true;
int currentId = 0;
Dictionary<int, string> names = new Dictionary<int, string>();
//Dictionary<int, string> name2 = new Dictionary<int, string>();
//Dictionary<int, string> name3 ;
Dictionary<int, string> lastnames = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> favorites = new Dictionary<int, bool>();

while (running) //(++currentId++ > 5)
{


    Console.WriteLine("Please chose an option");
    Console.WriteLine("1. Add, 2. Edit, 3. View All, 4. Search, 5. Delete 6. Exit");

    var chosenOption = int.Parse(Console.ReadLine());

    switch (chosenOption)
    {
        case 1: //adding contacts 
            AddNewContactToDictionary();
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

                            //var finded = names.Where(x => x.Key == typedId).FirstOrDefault();
                            //if (finded == null)
                            //{  
                            //}

                            PrintHeader();
                            Console.WriteLine($"{typedId}     {names[typedId]}        {lastnames[typedId]}      {addresses[typedId]}      {emails[typedId]}    {ages[typedId]}       {(favorites[typedId] ? "Yes" : "No")}");
                        }
                        break;
                    case "2":
                        {
                            Console.WriteLine("Please type the name");
                            var name = Console.ReadLine();

                            PrintHeader();

                            var findedNames = names.Where(x => x.Value.ToLower().Contains(name.ToLower())).ToList();

                            foreach (var item in findedNames)
                            {
                                Console.WriteLine($"{item.Key}     {names[item.Key]}        {lastnames[item.Key]}      {addresses[item.Key]}      {emails[item.Key]}    {ages[item.Key]}       {(favorites[item.Key] ? "Yes" : "No")}");
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
    for (int i = 0; i < names.Count; i++)
    {
        // var isFavoriteOrNot = favorites[i] == true ? "Yes" : "No";
        // var isFavoriteOrNot = favorites[i] ? "Yes" : "No";

        var id = i + 1;
        Console.WriteLine($"{id}     {names[id]}        {lastnames[id]}      {addresses[id]}      {emails[id]}    {ages[id]}       {(favorites[id] ? "Yes" : "No")}");
    }
}
void AddNewContactToDictionary()
{
    // currentId = currentId + 1;
    currentId += 1;
    //currentId++;//more used
    // ++currentId;
    Console.WriteLine("Type a name");
    //var name = Console.ReadLine();
    // names.Add(name);
    names.Add(currentId, Console.ReadLine());

    Console.WriteLine("Type a lastname");
    var lastname = Console.ReadLine();
    lastnames.Add(currentId, lastname);

    Console.WriteLine("Type an address");
    var address = Console.ReadLine();
    addresses.Add(currentId, address);

    Console.WriteLine("Type a email");
    var email = Console.ReadLine();
    emails.Add(currentId, email);

    Console.WriteLine("Type an age");
    var age = Convert.ToInt32(Console.ReadLine());
    ages.Add(currentId, age);

    Console.WriteLine("Is favorite Contact? 1. Yes, 2. No");

    var isFavorite = Console.ReadLine() == "1" ? true : false;

    favorites.Add(currentId, isFavorite);

}
//    }
//}
