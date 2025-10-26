using System;

class Program
{
    static void Main(string[] args)
    {
        string exit = "";

        //scripture list
        Word word_display = new Word();

        string _word = word_display.SetWord();

        Referance references = new Referance();


        Scripture list_display = new Scripture();



        while (exit != "quit".ToLower())
        {
        list_display.ToList(_word);

        references.DisplayReferance();
        list_display.DisplayWords();

        list_display.replaceWords();

        Console.WriteLine("\nPress enter to continue or type 'quit' to finish");
        string user_input = Console.ReadLine();


        Console.Clear();

        if (user_input.ToLower() == "quit")
        {
            exit = "quit";
        }   
        }

    }
    
}