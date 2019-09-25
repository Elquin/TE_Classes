using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given a List of Integers, and an int value, return true if the int value appears two or more times in
         the list.
         FoundIntTwice( [5, 7, 9, 5, 11], 5 ) -> true
         FoundIntTwice( [6, 8, 10, 11, 13], 8 -> false
         FoundIntTwice( [9, 23, 44, 2, 88, 44], 44) -> true
         */
        public bool FoundIntTwice(List<int> integerList, int intToFind)
        {
            //setup integer to store count starts at 0
            //setup up for each to go through each value of integerList
            //Setup if loop. If (list == intToFind) -> count = count + 1
            //else if it's not == continue
            //if count >= 2 = return true, else return false
            int count = 0;
            foreach (int number in integerList)
            {
                if (number == intToFind)
                {
                    count++;
                }
                else
                {
                    continue;
                }
                if (count >= 2)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
