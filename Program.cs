// See https://aka.ms/new-console-template for more information

using AddressBookSystem;
AddressBook addressBook = new AddressBook();
bool flag = true;
while (flag)
{
    Console.WriteLine("Enter Value:\n1.Add new Contact\n2.Update Contact\n3.Exit");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            
            addressBook.CreateContact();
            break;
        case 2:
            //AddressBook addressBook1 = new AddressBook();
            addressBook.UpdateContact();
            break;
        case 3:
            flag = false;
            break;
    }

}