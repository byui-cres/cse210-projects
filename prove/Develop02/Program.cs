class Program
{
    
    static void Main(string[] args)
    {   
        List<string> userJournalEntries = new List<string>();
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("");
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        
        string userChoice = "";
        while (userChoice != "5")
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("");
            Console.Write("Choice: ");
            userChoice = Console.ReadLine();
            Console.WriteLine("");

        if (userChoice == "1")
        {   
            Prompts randomPrompt = new Prompts();
            string prompt = randomPrompt.DisplayPrompts();
            Console.WriteLine(prompt);
            Console.Write("Entry: ");
            string userEntry = Console.ReadLine();
            Entries userEntries = new Entries();
            userJournalEntries.Add($"Data:{dateText} - {prompt} \n {userEntry}");
        }
        else if (userChoice ==  "2")
        {
            Entries displayEntries = new Entries();
            displayEntries.DisplayJournal(userJournalEntries);
        }
        else if (userChoice ==  "3")
        {
            Entries loadFile = new Entries();
            Console.WriteLine("Filename: ");
            string filename = Console.ReadLine();
            loadFile.LoadJournal(filename, userJournalEntries);
        }
        else if (userChoice ==  "4")
        {
            Entries saveFile = new Entries();
            Console.Write("Filename: ");
            string filename = Console.ReadLine();
            saveFile.SaveJournal(filename, userJournalEntries);
        }
        else if (userChoice ==  "5")
        {
            Console.WriteLine("Happy Jounaling... ");
            Environment.Exit(0);
            Console.WriteLine("");
        }else{
            Console.WriteLine($"Try again: {userChoice} is not in the choices");
            Console.WriteLine("");
        }

        }
    }
}