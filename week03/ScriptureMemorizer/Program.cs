using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("Alma", 5, 14);

        Scripture scripture = new Scripture(reference,
            "And now behold, I ask of you, my brethren of the church, have ye spiritually been born of God? Have ye received his image in your countenances? Have ye experienced this mighty change in your hearts?");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.CompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(4);
        }
    }
    
}