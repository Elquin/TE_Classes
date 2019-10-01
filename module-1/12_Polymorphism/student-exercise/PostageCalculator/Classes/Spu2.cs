using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class Spu2 : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = (weight * 0.050) * distance;
            return rate;

        }

        public string TypeOfDelivery
        {
            get { return "SPU (2-Day Business)"; }
        }
    }
}
