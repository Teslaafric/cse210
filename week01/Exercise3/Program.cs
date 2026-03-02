using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
       
        // int randomNumber = 0;
        string response = "yes";
        Random  randomNumber = new Random();
      

        // Console.Write("Enter a random number: ");
        // string number = Console.ReadLine();
        // randomNumber = int.Parse(number);
        
        while (response == "yes")
        {  
            int guessNumber = -1;
            int guessCount = 0;
            int number = randomNumber.Next(1, 101);

            while (guessNumber != number)
            {
                Console.Write("What is your guess number: ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                guessCount ++;

                if (guessNumber > number)
                {
                    Console.WriteLine("The guess number is higher! Go lower.");
                }
                else if (guessNumber < number)
                {
                    Console.WriteLine("The guess number is lower! Go higher.");
                }
                else
                {
                    Console.WriteLine($"You guessed right! {guessCount} guesses"); 
                }
            }   
            Console.Write("Would you like to play again? yes/no: ");
            response = Console.ReadLine().ToLower();

        }       
        Console.WriteLine("Goodbye");
            
    }
}
