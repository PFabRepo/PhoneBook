using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from PhoneBook app");

            Console.WriteLine("1: Add Contact");
            Console.WriteLine("2: Display contact by number");
            Console.WriteLine("3: Display all contacts");
            Console.WriteLine("4: Search contacts");
            Console.WriteLine("To exit insert 'x' ");

            var userInput = Console.ReadLine();

            PhoneBook phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Insert number");
                        string number = Console.ReadLine();
                        Console.WriteLine("Insert name");
                        string name = Console.ReadLine();

                        Contact newContact = new Contact(name, number);

                        phoneBook.AddNewContact(newContact);

                        break;
                    case "2":
                        Console.WriteLine("Insert number");
                        string numberToSearch = Console.ReadLine();

                        phoneBook.DisplayContact(numberToSearch);

                        break;
                    case "3":

                        phoneBook.DisplayAllContacts();
                        break;
                    case "4":

                        Console.WriteLine("Insert search phrase");
                        var searchPhrase = Console.ReadLine();

                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;
                    case "x":
                        return;

                    default:
                        Console.WriteLine("Invalid Number");
                        break;
                }
                Console.WriteLine("Select Operation");
                userInput = Console.ReadLine();
            }
            


        }
    }
}
