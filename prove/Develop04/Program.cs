using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        bool option = true;
        while (option)
        {


            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    fullbreathing();
                    PauseAndClear();
                    break;
                case "2":
                    fullreflection();
                    PauseAndClear();    
                    break;
                case "3":
                    fulllisting();
                    PauseAndClear();
                    break;
                case "4":
                    option = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        }
    }
    static void fullbreathing()
    {
        Breathing intro1 = new Breathing("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
        intro1.OpeningMessage();
        intro1.SpinnerAnimation();
        Console.Clear();
        intro1.BreathingActivity();
        intro1.ClosingMessage();

    }
    static void fullreflection()
    {
        Reflection intro2 = new Reflection("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
        intro2.OpeningMessage();
        intro2.SpinnerAnimation();
        Console.Clear();
        intro2.ReflectionActivity();
        intro2.ClosingMessage();
    }
    static void fulllisting()
    {
        Listing intro3 = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
        intro3.OpeningMessage();
        intro3.SpinnerAnimation();
        Console.Clear();
        intro3.ListingActivity();
        intro3.ClosingMessage();
    }

    static void PauseAndClear()
    {
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
        Console.Clear();
    }
}



