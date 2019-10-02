using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SpuNext : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = (weight * 0.075) * distance;
            return rate;

        }

        public string TypeOfDelivery
        {
            get { return "SPU (Next Day)            "; }
        }
    }
}
