using System;

class Program
{
    static void Main(string[] args)
    {
        //loops
        // && means and. || means or

        //foreach loops
        List<string> fruits = new List<string>() { "apple", "banana", "cherry" };
        foreach (string fruit in fruits)
        {
            //will loop through the list and print out each variable
            Console.WriteLine(fruit);
        }

        fruits.Add("Date");
        fruits.Add("Eggplant");

        fruits[0] = "Apricot";

        Console.WriteLine(fruits[0]);

        //for loops(used for counting)
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"i: {i}");
        }

        // while (used for looping until a condition is met)
        Console.Write("Make a choice (Y or N) ");
        string value = Console.ReadLine().ToUpper();

        while (value != "Y" && value != "N")
        {
            Console.Write("choose y or n: ");
            value = Console.ReadLine().ToUpper();
        }

        //do while loops
        // string value;
        do
        {
            Console.Write("Enter y or n: ");
            value = Console.ReadLine().ToUpper();

        } while (value != "Y" && value != "N");


    }
}