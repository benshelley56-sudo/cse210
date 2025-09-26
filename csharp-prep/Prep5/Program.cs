using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //main section to display and run 
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        int birthYear;
        PromptUserBirthYear(out birthYear);

        DisplayResult(userName, squaredNumber, birthYear);


        //FUNCTIONS
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");

        }


        static string PromptUserName()
        {

            Console.Write("Please enter your name: ");
            string username = Console.ReadLine();

            return username;
        }


        static int PromptUserNumber()
        {

            Console.Write("Please enter your favorite number: ");
            int usernumber = int.Parse(Console.ReadLine());

            return usernumber;
        }

        //why is promptusernumber not void but promptuserbirthyear
        static void PromptUserBirthYear(out int userbirth)
        {
            Console.Write("Please enter the year you were born: ");
            userbirth = int.Parse(Console.ReadLine());

        }



        static int SquareNumber(int usernumber)
        {
            int numbersquare = usernumber * usernumber;

            return numbersquare;
        }


        static void DisplayResult(string username, int numbersquare, int userbirth)
        {
            Console.WriteLine($"{username}, the square of your number is {numbersquare}");
            Console.WriteLine($"{username}, you will turn {2025 - userbirth} this year.");
        }

        
    }
}