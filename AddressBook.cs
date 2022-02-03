namespace AddressBookSystem
{
    public class AddressBook
    {
        List<Contacts> address = new List<Contacts>();
        public void CreateContact()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter First Name:");
            contacts.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            contacts.LastName = Console.ReadLine();

            Console.WriteLine("Enter Address:");
            contacts.Address = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            contacts.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter State:");
            contacts.State = Console.ReadLine();

            Console.WriteLine("Enter City:");
            contacts.City = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            contacts.Email = Console.ReadLine();

            Console.WriteLine("Enter Zip:");
            contacts.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Created Contact:\n{contacts.FirstName}\n{contacts.LastName}\n{contacts.Address}" +
                $"{contacts.PhoneNumber}\n{contacts.State}\n{contacts.City}\n{contacts.Email}\n{contacts.Zip}");
            address.Add(contacts);
        }
    }
}

