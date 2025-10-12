


public class Journal
{

    public List<string> _journal = new List<string>();

    public void AddEntryList(string entry)
    {
        _journal.Add(entry);

    }
    public void DisplayJournal()
    {
        if (_journal.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            Console.WriteLine("Your journal entries:");
            foreach (string entry in _journal)
            {
                Console.WriteLine(entry);
            }
        }
    }

        //I didnt have the time to get to the saving and loading files
    // public void SaveToFile(string filename)
    // {

    // }
    // public void LoadFromFile(String filename)
    // {

    // }
}