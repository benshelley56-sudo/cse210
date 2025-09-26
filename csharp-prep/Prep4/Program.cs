using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        int usernum = -5;
        while (usernum != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();
            usernum = int.Parse(userResponse);


            if (usernum != 0)
            {
                numbers.Add(usernum);
            }

        }

        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"the total is {total}");

        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");






        // //CLASS NOTES
        // int x = 2;
        // int y = 4;
        // int sum = adding(x, y);
        // Console.WriteLine(sum);

        // Console.WriteLine($"x before: {x}");
        // changevalue(x);
        // Console.WriteLine($"X after: {x}");


        // int[] myarray = new int[] { 1, 2, 3, 4, 5 };


    }
    // //CLASS NOTES
    // //writing functions
    // //if making a function that does not return anything use "void" in place of int, string, etc.
    // //adding integers
    // static int adding(int a, int b)
    // {
    //     return a + b;
    // }

    // //pass by value
    // static void changevalue(int x)
    // {
    //     x = 100;
    // }

    // //using integer lists
    // static void changereferance(int[] data)
    // {
    //     data[2] = 100;
    // }
}