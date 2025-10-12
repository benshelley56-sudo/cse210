using System;

 class Program
{
    static void Main()
    {
        

        int choice = 0;
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the journal Program! ");

        while (choice != 5)
        {

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {

                Prompt prompt = new Prompt();
                prompt.GetPrompt();
                string entry = Console.ReadLine();
                DateTime currentDateTime = DateTime.Now;


                string journal_log = $"Date: {currentDateTime} - Prompt: {entry}";



                journal.AddEntryList(journal_log);

            }
            else if (input == 2)
            {

                journal.DisplayJournal();
            }

            else if ( input == 3)
            {
                Console.WriteLine("this is an unfinished feature :(");
            }

            else if (input == 4)
            {
                Console.WriteLine("this is an unfinished feature :(");
            }



            else if (input == 5) {
                break;
            }
        

        }
    }
}

