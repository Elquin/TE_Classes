using System;
using System.Collections.Generic;

namespace RomanNumeralsTDD
{
    public class RomanNumeral
    {
        public string ToRoman(int number)
        {

            Dictionary<int, string> numerals = new Dictionary<int, string>()
            {
                {1000, "M" },
                {900, "CM" },
                {500, "D" },
                {400, "CD" },
                {100, "C" },
                {90, "XC" },
                {50, "L" },
                {40, "XL" },
                {10, "X" },
                {9, "IX" },
                {5, "V" },
                {4, "IV" },
                {1, "I" },
            };

            string result = "";

            foreach (int key in numerals.Keys)
            {
                while (number >= key)
                {
                    result += numerals[key];
                    number -= key;
                }
            }

            #region
            //switch (number)
            //{
            //    case 1:
            //        result += "I";
            //        number -= 1;
            //        break;
            //    case 5:
            //        result += "V";
            //        break;
            //    case 10:
            //        result += "X";
            //        break;
            //    case 50:
            //        result += "L";
            //        break;
            //    case 100:
            //        result += "C";
            //        break;
            //    case 500:
            //        result += "D";
            //        break;
            //    case 1000:
            //        result += "M";
            //        break;
            //}
            #endregion

            return result;

        }
    }
}