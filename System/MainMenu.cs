using Newtonsoft.Json;

namespace jepproject.System;


internal class MainMenu
{
    private List<Contact> contacts = new List<Contact>();
    private FileService fileService = new FileService();
    public string Path { get; set; } = null!;
    public void WelcomeMenu()
    {
       PopulateContacts();

        Console.Clear();
        Console.WriteLine("Välkommen till Adressboken");
        Console.WriteLine("1. Skapa en kontakt");
        Console.WriteLine("2. Visa alla kontakter");
        Console.WriteLine("3. Visa en specifik kontakt");
        Console.WriteLine("4. Ta bort en specifik kontakt");
        Console.WriteLine("Välj ett av alternativen ovan: ");
        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1": CreateContact(); break;
            case "2": ShowAllContacts(); break;
            case "3": SearchContact(); break;
            case "4": RemoveContact(); break;
            default: Console.WriteLine("Inte ett ordentligt val, tryck valfri tangent för att återvända."); 
                Console.ReadKey(); break;
        }
    }

    private void PopulateContacts()
    {
        try
        {
            var items = JsonConvert.DeserializeObject<List<Contact>>(fileService.Read(Path));
            if (items != null)

                contacts = items;
                Console.WriteLine(items);
            
        } 
        catch 
        {
            Console.WriteLine("ERROR");
        }
        
    }

    


    private void CreateContact() 
    {
        Contact contact = new Contact();

        Console.Clear();
        Console.WriteLine("Skapa en kontakt");
        Console.WriteLine("Förnamn: ");
        contact.FirstName = Console.ReadLine() ?? "";
        Console.WriteLine("Efternamn: ");
        contact.LastName = Console.ReadLine() ?? "";
        Console.WriteLine("Email: ");
        contact.Email = Console.ReadLine() ?? "";
        Console.WriteLine("Adress: ");
        contact.Adress = Console.ReadLine() ?? "";
        Console.WriteLine("Phone number: ");
        contact.Number = Console.ReadLine() ?? "";

        
        Console.WriteLine("The following contact has been created: ");
        Console.WriteLine($"{contact.FirstName} {contact.LastName}");
        Console.WriteLine(contact.Email);
        Console.WriteLine(contact.Adress);
        Console.WriteLine(contact.Number);

        Console.WriteLine("Tryck valfri knapp för att återgå till menyn.");
        Console.ReadKey();

        contacts.Add(contact);
        fileService.Save(Path, JsonConvert.SerializeObject(contacts));


    }

    private void ShowAllContacts()
    {
        
        //Load list against content.json on desktop
        Console.WriteLine("Alla kontakter:");
        foreach(Contact contact in contacts)
        {
            Console.WriteLine($"Kontaktens ID: {contact.Id}");
            Console.WriteLine(contact.FirstName);
            Console.WriteLine(contact.LastName);
            Console.WriteLine(contact.Email);
            Console.WriteLine(contact.Adress);
            Console.WriteLine(contact.Number);
            Console.WriteLine("\n");
        }
        Console.WriteLine("Det var alla kontakter, tryck valfri tangent för att återgå till huvudmenyn.");
        Console.ReadKey();
    }

    private void SearchContact()
    {
        //Search for a contact in list...
        
    }


    private void RemoveContact()
    {
        //Search and remove a contact from list... 
        
    }

}
