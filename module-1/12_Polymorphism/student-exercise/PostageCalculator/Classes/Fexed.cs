using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class Fexed : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = 20.00;
            if (distance > 500 && weight > 48)
            {
                rate += 8.00;
            }
            else if (distance > 500 && weight < 49)
            {
                rate += 5.00;
            }
            else if (distance < 501 && weight > 48)
            {
                rate += 3.00;
            }
            return rate;
            
        }

        public string TypeOfDelivery
        {
            get { return "FexEd                       "; }
        }
    }
}
