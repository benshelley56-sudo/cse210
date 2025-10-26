//will store the lists of wordsand keep track of the scriptures
using System.Runtime.CompilerServices;

public class Scripture
{
    private List<string> word_list = new List<string>();
    private Random random = new Random();

    public void replaceWords()
    {
        var indexes = Enumerable.Range(0, word_list.Count)
                                .OrderBy(_ => random.Next())
                                .Take(1)
                                .ToList();

        foreach (var i in indexes)
        {
            word_list[i] = new string('_', word_list[i].Length);
        }

        Console.WriteLine(string.Join(" ", word_list));

    }
    
    public void ToList(string _word)
    {

        string[] list = _word.Split(';', StringSplitOptions.RemoveEmptyEntries);

        word_list = new List<string>(list);

    }
    public void DisplayWords()
    {
        foreach (string word in word_list)
        {
            Console.Write(word);
        }
    }

    //
    public List<string> GetWord()
    {
        return word_list;
    }

} 