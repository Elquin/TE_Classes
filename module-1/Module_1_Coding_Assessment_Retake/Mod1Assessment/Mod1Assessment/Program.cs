using Mod1Assessment.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Mod1Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalPrice = 0;
            List<MovieRental> reservationList = new List<MovieRental>();
            using (StreamReader st = new StreamReader(@"..\..\..\Data\MovieInput.csv"))
            {
                while (!st.EndOfStream)
                {
                    string line = st.ReadLine();
                    string[] values = line.Split(",");

                    string title = values[0];
                    string format = values[1];
                    bool isPremium = bool.Parse(values[2]);

                    if (isPremium)
                    {
                        totalPrice += (decimal)1.00;
                    }

                    MovieRental newMovieRental = new MovieRental(title, format, isPremium);
                    newMovieRental.LateFee(2);
                    Console.WriteLine(newMovieRental.ToString());
                    totalPrice += decimal.Parse(newMovieRental.RentalPrice.ToString());
                }
                Console.WriteLine($"\nMovie Rental with Premium charge: {totalPrice}");

            }
            Console.ReadLine();

        }
    }
}
