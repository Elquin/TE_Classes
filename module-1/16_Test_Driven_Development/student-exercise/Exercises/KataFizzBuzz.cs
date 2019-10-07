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
            if (numberToTest % 3 == 0) 
            {
                return "Fizz"; //returns first condition for divisible by 3
            }
            else if (numberToTest % 5 == 0)
            {
                return "Buzz"; //returns second condition for divisible by 5
            }
            
        }
    }
}
