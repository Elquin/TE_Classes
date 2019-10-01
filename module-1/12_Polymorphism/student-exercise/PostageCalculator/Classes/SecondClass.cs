using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SecondClass : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = 0;
            if (weight > 0 && weight <= 2)
            {
                rate = 0.0035 * distance;
            }
            else if (weight > 2 && weight <= 8)
            {
                rate = 0.0040 * distance;
            }
            else if (weight > 8 && weight <= 15)
            {
                rate = 0.0047 * distance;
            }
            else if (weight > 15 && weight <= 48)
            {
                rate = 0.0195 * distance;
            }
            else if (weight > 48 && weight <= 128)
            {
                rate = 0.0450 * distance;
            }
            else
            {
                rate = .0500 * distance;
            }
            return rate;
        }

        public string TypeOfDelivery
        {
            get { return "Postal Service (2nd Class)"; }
        }
    }
}
