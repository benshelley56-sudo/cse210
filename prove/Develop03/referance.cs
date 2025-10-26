//contains the book, verse and scripture as a whole 

using System.Dynamic;

public class Referance
{
    private string _book = "Nephi";
    private int _chapter = 9;
    private int _verseOne = 14;
    private int _verseTwo = 15;

    public string GetBook()
    {

        return _book;
    }
    public int GetChapter()
    {

        return _chapter;
    }
    public int Getverse_one()
    {
        return _verseOne;
    }
    public int Getverse_two()
    {
        return _verseTwo;
    }

    public void DisplayReferance()
    {
        Console.Write($"{_book} {_chapter}:{_verseOne}-{_verseTwo} \n");
    }


}
