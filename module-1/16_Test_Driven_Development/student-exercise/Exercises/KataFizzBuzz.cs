using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        public string ToFizzBuzz(int numberToTest)
        {
            if (numberToTest <= 0 || numberToTest > 100)
            {
                return "";
            }
            else if (numberToTest % 3 == 0 && numberToTest % 5 == 0 || numberToTest.ToString().Contains("3") && numberToTest.ToString().Contains("5")) //Added Part 2 to pass test.
            {
                return "FizzBuzz"; //3rd step. Added condition with most restrictions to test for divisible by 3 and 5.
            }
            else if (numberToTest % 3 == 0) 
            {
                return "Fizz"; //returns first condition for divisible by 3
            }
            else if (numberToTest % 5 == 0)
            {
                return "Buzz"; //returns second condition for divisible by 5
            }
            else
            {
                return $"{numberToTest}";
            }



            //else if (numberToTest > 0 && numberToTest <= 100)
            //{
            //    return $"{numberToTest}";
            //}
            //else
            //{
            //    return "";
            //}
        }
    }
}
