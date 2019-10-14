using Mod1Assessment.Models;
using System;

namespace Mod1Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            string manufacturer = "Simons";
            decimal deposits = 30.00M;
            decimal withdrawal = 10.00M;

            TellerMachine newTellerMachine = new TellerMachine(manufacturer, deposits, withdrawal)
            {

            };

            System.Console.WriteLine(newTellerMachine.Balance());
            Console.ReadLine();


            //Started cardValid
            //string cardNumber = "57385863949583846";

            //bool cardValid(cardNumber)
            //{
            //    if (cardNumber[0] == 5 && cardNumber.Length == 16)
            //    {
            //        return true;
            //    }
            //    else if (cardNumber[0] == 4 && (cardNumber.Length == 13 || cardNumber.Length == 16)
            //}


        }
    }
}
