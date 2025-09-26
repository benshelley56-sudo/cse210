using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {

        //W01 prove part 2 CALCULATING GRADE
        Console.WriteLine("Start C# Prigram-2");

        Console.Write("What is your grade Percentage? ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";
        string sign = "";
        //find letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";

        }
        else if (grade >= 70)
        {
            letter = "C";

        }
        else if (grade >= 60)
        {
            letter = "D";

        }
        else if (grade < 60)
        {
            letter = "F";

        }

        //Determine if grade is +/- with A and F exception 
        //A exception
        if (grade >= 94)
        {
            if (Math.Abs(grade) % 10 <= 3)
            {
                sign = "-";
                Console.WriteLine($"Your Grade is {letter}{sign} ");
            }

            else
                Console.WriteLine($"Your Grade is {letter} ");
        }


        else if (grade >= 60)
        {
            if (Math.Abs(grade) % 10 >= 7)
            {
                sign = "+";
                Console.WriteLine($"Your Grade is {letter}{sign} ");

            }

            else if (Math.Abs(grade) % 10 <= 3)
            {
                sign = "-";
                Console.WriteLine($"Your Grade is {letter}{sign} ");
            }

            else
                Console.WriteLine($"Your Grade is {letter} ");
        }

        else if (grade < 60)
        {
            Console.WriteLine($"Your Grade is {letter} ");

        }

        //do you pass the class?
        if (grade >= 70)
        {
            Console.WriteLine("You are passing the Class!!");
            Console.WriteLine("YAYYY Congragulations! you get an icecream cone");
        }
        else
        {
            Console.WriteLine("You are failing the Class:(");
            Console.WriteLine("you almost had it, keep studying and you'll get it!");
        }

    }
}