using ContactBookApp.utility;

var contactBook = new ContactBooks();
bool exit = false;
while (!exit)
{
    Console.WriteLine("1 : Add a new contact");
    Console.WriteLine("2 : Remove an existing contact");
    Console.WriteLine("3 : find a conatct by name");
    Console.WriteLine("4: list all contact");
    Console.WriteLine("5 : Exit the program");


    Console.WriteLine("enter ypour choice");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            contactBook.AddContact();
            break;
        case 2:
            contactBook.RemoveContact();
            break;
        case 3:
            contactBook.GetContact();
            break;
        case 4:
            exit = true;
            break;
        default:
            Console.WriteLine("you entered an invalid choice");
            break;


    }

}



