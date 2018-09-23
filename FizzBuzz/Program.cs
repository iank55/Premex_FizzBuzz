using System;
using FizzBuzzEngine;

namespace FizzBuzz
{
    class Program
    {


        static void Main(string[] args)
        {
            FizzBuzzEngine.FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine.FizzBuzzEngine();

            for (int i = 1; i <= 100; i++) 
            {
                Console.WriteLine(fizzBuzzEngine.ConvertToFizzBuzz(i));
            }

            Console.ReadLine();

        }
    }
}
