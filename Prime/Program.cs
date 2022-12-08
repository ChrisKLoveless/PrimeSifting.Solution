using System;
using Prime.Models;
using Prime;
using System.Collections.Generic;

namespace Prime.Program
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input a number from 1 to 100");
            string? stringUserInput = Console.ReadLine();
            int userInput = 0;
            int.TryParse(stringUserInput, out userInput);
            Console.WriteLine("Your prime numbers are:\n");
            for (int i = 0; i <= userInput; i++)
            {
                if (i > 1)
                {
                    bool valid = Number.isPrime(i);
                    if (valid) 
                    {
                        Console.WriteLine(i);
                    }
                }
                
            }
        }
    }
}

            // Number userNum = new Number(userInput);
            // List<int> inputList = new List<int> { 2, 2 };
            // Console.WriteLine("------------");

            // for (int i = 2; i <= userInput; i++)
            // {
                
            //     inputList.Add(i);
            // }
            // Console.WriteLine(inputList[i]);
            // // List<int> numList = int.Parse(inputList);
            // // List<int> outputList = new List<int> { numList };
            // foreach (int oi in inputList)
            // {
            //     if (oi % 2 == 0)
            //     {
            //         inputList.Remove(oi);
            //     }
            //     Console.WriteLine(inputList[oi]);
            // }