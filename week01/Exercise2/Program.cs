using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage: ");
        string number = Console.ReadLine();
        int percentage = int.Parse(number);

        string letter = "";
        string character = "";

        if (percentage >= 90)
        {
            if (percentage % 10 >= 7 || percentage == 100)
            {
                
                letter = "A";
                character = ""; 
            }
            else if (percentage % 10 >= 3)
            {
                letter = "A";
                character = ""; 
            }
            else if (percentage % 10 < 3 || percentage == 90)
            {    
                letter = "A";
                character = "-";
            }
        }  
        else if (percentage >= 80)
        {
            if (percentage % 10 >= 7)
            {
                letter = "B";
                character = "+";
            }
            else if (percentage % 10 >= 3 && percentage != 80)
            {
                letter = "B";
                character = "";
            }
            else
            {
                letter = "B";
                character = "-";
            }

        }
        else if (percentage >= 70)
        {   
            if (percentage % 10 >= 7)
            {
                letter = "C";
                character = "+";
            }
            else if (percentage % 10 >= 3 && percentage != 70)
            {
                Console.WriteLine("Congratulation! You passed.");
                letter = "C";
                character = "";
            }
            else
            {
                Console.WriteLine("Congratulation! You passed.");
                letter = "C";
                character = "-";
            }
        }

        else if (percentage >= 60)
        {   
            if (percentage % 10 >= 7)
            {
                letter = "D";
                character = "+";
            }
            else if (percentage % 10 >= 3 && percentage != 60)
            {
                letter = "D";
                character = "";
            }
            else
            {
                letter = "D";
                character = "-";
            }
        }
        else
        {   
            letter = "F";
            character = "";
        }
        Console.WriteLine($"Grade: {letter}{character}");
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulation! You passed.");
        }
        else
        {
            Console.WriteLine("You didn't pass. Retake course for better grade.");
        }

    }
}