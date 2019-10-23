using System;
using System.Collections.Generic;
using System.Text;

namespace Mod1Assessment.Models
{
    public class MovieRental
    {
        //properties
        public string Title { get; set; }
        public string Format { get; set; }
        public bool IsPremiumMovie { get; set; }
        public decimal RentalPrice
        {
            get
            {
                if (Format == "VHS")
                {
                    return (decimal)0.99;
                }
                else if (Format == "DVD")
                {
                    return (decimal)1.99;
                }
                else
                {
                    return (decimal)2.99;
                }
            }
        }

        //constructor
        public MovieRental(string title, string format, bool isPremium)
        {
            Title = title;
            Format = format;
            IsPremiumMovie = isPremium;
        }

        public decimal LateFee(int daysLate)
        {
            if (daysLate > 2)
            {
                return (decimal)19.99;
            }
            else if (daysLate == 2)
            {
                return (decimal)3.99;
            }
            else if (daysLate == 1)
            {
                return (decimal)1.99;
            }
            else
            {
                return (decimal)0.0;
            }
        }


        public override string ToString()
        {
            return $"MOVIE - {Title} - {Format} - {RentalPrice}";
        }
    }
}
  

