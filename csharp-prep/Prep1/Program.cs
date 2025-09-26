using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
         //W01 prove part 1

        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}. \n");







    }
}

        // //CLASS NOTES
        
        // Console.WriteLine("Hello Prep1 World!");

        // String firstname = "bob";

        // //print and printf are the same as Console.Writeline("") and Console.Writeline($"")
        // Console.WriteLine("hello " + firstname);
        // Console.WriteLine($"hello {firstname}");
        // Console.Write("using just >write will not automatically start on a new line, Using .WriteLine will\n");

        // //user input
        // Console.Write("What is your favorite color? ");
        // string favoriteColor = Console.ReadLine();


        // Console.Write("How old are you? ");
        // int age = int.Parse(Console.ReadLine());
        // Console.WriteLine($"{firstname}, You are {age}years old. ");

        // //using intagerse
        // int a = 13;
        // int b = 7;

        // int c = a + b;
        // Console.WriteLine($"c is {c}");
        // Console.WriteLine($"{(double)a / b}");

        // double x = 1.5; //double handle 15-16 digits precision 
        // float y = 1.5f; //floating point numbers handle up to 7 digit precision

        // bool isdone = false;

        // if (isdone)
        // {
        //     Console.WriteLine("all done ");

        // }
        // else
        // {
        //     Console.WriteLine("Not done yet");
        // }