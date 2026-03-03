using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string name =  PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(name, squared);

    }
    
    static void DisplayWelcome ()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName ()
    {
        Console.Write("What is your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber ()
    {
        Console.Write("What is your favourite number: ");
        int number =int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber (int number)
    {
        return number * number;
    }
    static void DisplayResult (string userName, int squaredNumber)
    {
        Console.Write($"{userName}, the square of your favourite number is {squaredNumber}");
    }

}