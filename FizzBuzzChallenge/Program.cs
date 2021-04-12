using System;

namespace FizzBuzzChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a Number: ");
            FizzBuzz();
            FizzBuzz();
            FizzBuzz();
        }

        public static void FizzBuzz()
        {
            int number = int.Parse(Console.ReadLine());
            
            if(number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if(number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if(number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("Not divisible by 3 or 5.");
            }
        }
    }
}
