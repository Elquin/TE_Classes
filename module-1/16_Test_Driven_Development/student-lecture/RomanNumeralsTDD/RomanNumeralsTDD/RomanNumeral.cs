using System;

namespace RomanNumeralsTDD
{
    public class RomanNumeral
    {
        public string ToRoman(int number)
        {

            string result = "";
            if (number < 5)
            {
                for (int i = 1; i <= number; i++)
                {
                    result += "I";
                }
            }
            else if (number < 10)
            {
                for (int i = 5; i <= number; i += 5)
                {
                    result += "V";
                }
            }
            else if (number < 50)
            {
                for (int i = 10; i <= number; i += 10)
                {
                    result += "X";
                }
            }
            else if (number < 100)
            {
                for (int i = 50; i <= number; i += 50)
                {
                    result += "L";
                }
            }
            else if (number < 500)
            {
                for (int i = 100; i <= number; i += 100)
                {
                    result += "C";
                }
            }
            else if (number < 1000)
            {
                for (int i = 500; i <= number; i += 500)
                {
                    result += "D";
                }
            }
            else /*(number >= 1000)*/
            {
                for (int i = 1000; i <= number; i += 1000)
                {
                    result += "M";
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