using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return true if it ends in "ly".
         EndsLy("oddly") → true
         EndsLy("y") → false
         EndsLy("oddy") → false
         */
        public bool EndsLy(string str)
        {
            string newString = str.ToLower();
            if (str.Length < 2)
            {
               return false;
            }
            else if ($"{newString.Substring(str.Length - 2)}" == "ly")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
