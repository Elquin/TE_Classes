using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Car : IVehicle
    {

        
        //properties
        public bool HasTrailer { get;  }
        //constructors

        public Car(bool hasTrailer)
        {
            HasTrailer = hasTrailer;
        }
        public double CalculateToll(int distance)
        {
            if (HasTrailer)
            {
                return (distance * 0.020) + 1.00;
            }
            else
            {
                return distance * 0.020;
            }
        }
        public override string ToString()
        {
            if (HasTrailer)
            {
                return "Car has trailer";
            }
            else
            {
                return "Car";
            }
        }

    }
}
