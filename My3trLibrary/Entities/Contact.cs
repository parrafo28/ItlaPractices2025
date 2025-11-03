namespace My3rdLibrary.Entities
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

        public static int GenerateId(List<Contact> contacts)
        {
            return contacts.Count + 1;
        }
    }
}
