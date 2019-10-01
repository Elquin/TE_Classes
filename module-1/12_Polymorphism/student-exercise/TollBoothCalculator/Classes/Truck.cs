using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Truck : IVehicle
    {


        //properties
        public int NumberOfAxles { get; }
        //constructors

        public Truck(int numberOfAxles)
        {
            NumberOfAxles = numberOfAxles;
        }
        public double CalculateToll(int distance)
        {
            if (NumberOfAxles >= 8)
            {
                return 0.048 * distance;
            }
            else if (NumberOfAxles == 6)
            {
                return 0.045 * distance;
            }
            else
            {
                return 0.040 * distance;
            }
        }
        public override string ToString()
        {
            return "Truck " + NumberOfAxles;
        }


    }
}
