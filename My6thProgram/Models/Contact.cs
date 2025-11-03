namespace My6thProgram.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public bool IsFavorite { get; set; }
        //int id;
        //string name;

        //public string Name
        //{
        //    get { return name; }

        //    set { name = value; }
        //}

        //public void SetName(string name)
        //{
        //    this.name = name;
        //}
        //public string GetName()
        //{
        //    return this.name;
        //}
        //public Contact(string name, string lastname, string address="",string email="", string phone="", int age = 0, bool isFavorite = false)
        //{
        //    Name = name;
        //    LastName = lastname;
        //    Address = address;
        //    Email = email;
        //    Phone = phone;
        //    Age = age;
        //    IsFavorite = isFavorite; 
        //}
        //public Contact(string name, string lastname, string address)
        //{
        //    Name = name;
        //    LastName = lastname;
        //    Address = address;

        //}
        public void CreateContact(string name, string lastname, string address = "", string email = "", string phone = "", int age = 0, bool isFavorite = false)
        {
            Name = name;
            LastName = lastname;
            Address = address;
            Email = email;
            Phone = phone;
            Age = age;
            IsFavorite = isFavorite;
        }
        public Contact CreateContact2(string name, string lastname, string address = "", string email = "", string phone = "", int age = 0, bool isFavorite = false)
        {
            Name = name;
            LastName = lastname;
            Address = address;
            Email = email;
            Phone = phone;
            Age = age;
            IsFavorite = isFavorite;
            return this;
        }

        public static int GenerateId(List<Contact> contacts)
        {
            return contacts.Count + 1;
        }
    }
}
