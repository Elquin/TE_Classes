﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public partial class LectureExample
    {
        /*
        16. Return "Big Even Number" when number is even, larger than 100, and a multiple of 5.
            Return "Big Number" if the number is just larger than 100.
            Return empty string for everything else.
            TOPIC: Complex Expression
        */
        public string ReturnBigEvenNumber(int number)
        {        
            if (number % 2 == 0 //number is even
                && number > 100 //number is greater than 100
                && number % 5 == 0
                )
            {
                return "Big Even Number";
            }
            else if (number > 100)
            {
                return "Big Number";
            }
            return "";
        }
        


    }
}
