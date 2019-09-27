using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// Represents a "simple" calculator
    /// </summary>
    public class Calculator
    {

        //constructor
        public Calculator()
        {
            int Result = 0;
        }

        //Class properties
        public int Result { get; private set; }

        //Methods
        public int Add(int addend)
        {
            Result = addend + Result;
            return Result;
        }

        public int Multiply(int multiplier)
        {
            Result = Result * multiplier;
            return Result;

        }

        public int Power(int exponent)
        {
            Result = (int)Math.Pow(Result, exponent);
            return Result;
        }

        public void Reset()
        {
            Result = 0;
        }

        public int Subtract(int subtrahend)
        {
            Result = Result - subtrahend;
            return Result;
        }
    }
}
