// See https://aka.ms/new-console-template for more information

using AddressBookSystem;

bool flag = true;
while (flag)
{
    Console.WriteLine("Enter Value:\n1.Add to Contacts\n2.Exit");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            AddressBook addressBook = new AddressBook();
            addressBook.CreateContact();
            break;
        case 2:
            flag = false;
            break;
    }

}