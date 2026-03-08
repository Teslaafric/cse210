using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        double total = 0;
        int number = -1;
        List<int> myNumbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, and 0 when done: ");
       
       
        while (number != 0)
        {
          
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                myNumbers.Add(number);
            }
            
          
        }
        foreach (int item in myNumbers)
        {
            total +=item;
        }
        int maxNumber = myNumbers[0];
        int minPositive = int.MaxValue;
        for (int i= 1; i < myNumbers.Count; i++)
        {
            if (myNumbers[i] > maxNumber)
            {
                maxNumber = myNumbers[i];
            }
           
        }
        for (int i= 0; i < myNumbers.Count; i++)
        {
            if (myNumbers[i] > 0 && myNumbers[i] < minPositive)
            {
                minPositive = myNumbers[i];
            }
        
        }

       
         
        Console.WriteLine($"The sum of the numbers: {total}");
        double average = total / myNumbers.Count;
        // int count = myNumbers.Count;
        Console.WriteLine($"The average number: {average}");
        Console.WriteLine($"The largest number: {maxNumber}");
        
        if (minPositive == int.MaxValue)
        {
            Console.WriteLine("There are no positive numbers.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number: {minPositive}");
        }

        myNumbers.Sort();

        Console.WriteLine("The sorted list:");
        foreach (int numb in myNumbers)
        {
            Console.WriteLine(numb);
        }



    }
}