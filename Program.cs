using System;
//using FizzBuzz;

namespace TddUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            string y  = Console.ReadLine();
            Console.WriteLine(FizzBuzz.FizzBuzzMethod(Convert.ToInt32(y)));
        }
    }
}
