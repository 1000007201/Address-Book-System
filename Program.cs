// See https://aka.ms/new-console-template for more information

using AddressBookSystem;
AddressBook addressBook = new AddressBook();
bool flag = true;
while (flag)
{
    Console.WriteLine("Enter Value:\n1.Add new Contact\n2.Update Contact\n3.Delete Contact\n4.Exit");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            addressBook.CreateContact();
            break;
        case 2:
            addressBook.UpdateContact();
            break;
        case 3:
            addressBook.DeleteContact();
            break;
        case 4:
            flag = false;
            break;
    }

}