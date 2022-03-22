using System;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter an integer to check all prime numbers from 0-X: ");
            int input = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= input; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if(i%j == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(i);
                }
            }

                       
        }
    }
}
