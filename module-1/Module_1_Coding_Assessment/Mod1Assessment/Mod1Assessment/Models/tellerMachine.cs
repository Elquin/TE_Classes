using System;
using System.Collections.Generic;
using System.Text;

namespace Mod1Assessment.Models
{
    public class TellerMachine
    {

        //constructor
        public TellerMachine(string manufacturer, decimal deposits, decimal withdrawals)
        {
            Manufacturer = manufacturer;
            Deposits = deposits;
            Withdrawals = withdrawals;
        }

        //Class properties
        public string Manufacturer { get; set; }
        public decimal Deposits { get; set; }
        public decimal Withdrawals { get; set; }
       

        public decimal Balance()
        {
            return Deposits - Withdrawals;
        }

    }
}
