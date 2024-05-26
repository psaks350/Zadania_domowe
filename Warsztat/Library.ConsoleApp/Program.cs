using Library.Domain;
using Library.Persistence;

Book book = new Book("Dune", "Author", 2012, "234234234", 12, 29);
BooksRepository repository = new BooksRepository();

Console.WriteLine("Enter your login:");
string login = Console.ReadLine();

Console.WriteLine("Enter your password:");
string password = Console.ReadLine();

if (login == "Admin" && password == "password")
{
    Console.Clear();
    Console.WriteLine("Access Granted");
    string command = "";
    while (command != "wyjdz")
    {
        
        Console.WriteLine("Enter a command:");
        command = Console.ReadLine();

        switch (command)
        {
            case "dodaj":
                Console.Clear();
                Console.WriteLine("proba dodania ksiazki");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                break;
            case "usun":
                Console.WriteLine("proba usuniecia ksiazki");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                break;
            case "wypisz":
                Console.WriteLine("proba wypisania wszystkich ksiazek");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                break;
            case "zmien":
                Console.WriteLine("proba zmiany stanu magazynowego ksiazek");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                break;
            case "dodaj zamowienie":
                Console.WriteLine("proba dodania nowego zamowienia");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                break;
            case "lista zamowien":
                Console.WriteLine("proba wypisania wszystkich zamowien");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                break;
            case "wyjdz":
                break;
            default:
                Console.Clear();
                Console.WriteLine("Invalid command");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                break;
        }
        
    }
}
else
{
    Console.WriteLine("Access Denied");
}
