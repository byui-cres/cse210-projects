// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO; 
class Entries
{

    public void SaveJournal(string filename, List<string> journalEntries)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in journalEntries)
            {
                outputFile.WriteLine(entry);
            }
        }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("File not found");
            Console.WriteLine($"Error: {e}");
        }

    }

    public void LoadJournal(string filename, List<string> journalEntries)
    {
        string filename_ = filename;
        try
        {
            string[] lines = System.IO.File.ReadAllLines(filename_); 
            foreach (string line in lines)
            {
                journalEntries.Add(line);
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("File not found");
            Console.WriteLine($"Error: {e}");
        }

    }

    public void DisplayJournal(List<string> journalEntries)
    {
        foreach (var entry in journalEntries)
        {
            Console.WriteLine(entry);
            Console.WriteLine("");
        } 
        Console.WriteLine("");
    } 
}