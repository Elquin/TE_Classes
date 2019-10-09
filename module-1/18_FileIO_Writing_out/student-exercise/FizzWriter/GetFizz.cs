using System;
using System.Collections.Generic;
using System.Text;

namespace FizzWriter
{
    public class GetFizz
    {
        public string GetFizzNumber(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 5 == 0 || number.ToString().Contains("5"))
            {
                return "Buzz";
            }
            else if (number % 3 == 0 || number.ToString().Contains("3"))
            {
                return "Fizz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
