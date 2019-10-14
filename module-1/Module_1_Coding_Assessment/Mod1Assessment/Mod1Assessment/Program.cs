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


        }
    }
}
