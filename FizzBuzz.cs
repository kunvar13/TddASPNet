using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddUnitTesting
{
    public class FizzBuzz
    {
        public static string FizzBuzzMethod(int x)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                return "FizzBuzz";
            } 
            else if (x % 3 == 0)
            {
                return "Fizz";
            } 
            else if (x % 5 == 0 )
            {
                return "Buzz";
            } else
            {
                return "Not a FizzBuzz Number";
            }

        }
    }
}
