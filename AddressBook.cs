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
        public void UpdateContact()
        {
            Console.WriteLine("Enter First Name of which you have to edit:");
            string first_name = Console.ReadLine();
            Contacts contact = new Contacts();
            foreach(var data in address)
            {
                if (data.FirstName == first_name)
                {
                    contact = data;
                    return;
                }
            }

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter what to update:\n1.FirstName\n2.LastName\n3.Address\n4.PhoneNumber\n5.State\n6.City" +
                "\n7.Email\n8.Zip\n9.Exit Update Process");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter new FirstName:");
                        contact.FirstName = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter new LastName:");
                        contact.LastName = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter new Address:");
                        contact.Address = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter new Phone Number:");
                        contact.PhoneNumber = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Enter new State:");
                        contact.State = Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Enter new City:");
                        contact.City = Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Enter new Email:");
                        contact.Email = Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine("Enter new Zip:");
                        contact.Zip = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }
        }
    }
}

