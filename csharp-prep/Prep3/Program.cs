using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What Is the Magic Number? ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("What Is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        // //will change a string into a integer
        // if (int.TryParse(guess, out number))
        // {
            
        // }

        while (guess != number)
        {
            if (guess > number)
            {
                Console.Write("Lower");

            }
            else if (guess < number)
            {
                Console.Write("Higher");
            }

            Console.Write("\nWhat Is your guess? ");
            guess = int.Parse(Console.ReadLine());

        }
        Console.WriteLine($"\nYou guessed it! the Magic Number is {number}");

    }
}
