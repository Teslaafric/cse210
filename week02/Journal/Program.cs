using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

         Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        int userChoice = 0;

        while (userChoice != 5)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Exit");
            Console.Write("Select a choice: ");

            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write(">>>> ");
                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._randomPromptText = prompt;
                entry._textInput = response;

                Console.WriteLine("How was your mood today?");
                entry._myMood = Console.ReadLine();

                journal.AddEntry(entry);
            }
            else if (userChoice == 2)
            {
                journal.Display();
            }
            else if (userChoice == 3)
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();
                journal.Save(file);
            }
            else if (userChoice == 4)
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();
                journal.Load(file);
            }
            else if (userChoice == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Not a valid chioice!");
            }
        }
    }
    
}