using System;
using System.Collections.Generic;
using System.Text;

namespace Mod1Assessment.Models
{
    public class TellerMachine
    {

        //constructor
        public TellerMachine(string manufacturer, decimal deposits, decimal withdrawals, string cardNumber)
        {
            Manufacturer = manufacturer;
            Deposits = deposits;
            Withdrawals = withdrawals;
            CardNumber = cardNumber;
        }

        //Class properties
        public string Manufacturer { get; set; }
        public decimal Deposits { get; set; }
        public decimal Withdrawals { get; set; }
        public string CardNumber { get; set; }
        public decimal Balance
        {
            get
            {
                return Deposits - Withdrawals;
            }
        }

        public override string ToString()
        {
            return $"Balance: {Balance}";
        }

        public bool CardValid(string cardNumber)
        {
            if (CardNumber[0].Equals('5') && CardNumber.Length == 16)
            {
                return true;
            }
            else if (CardNumber[0].Equals('4') && (CardNumber.Length == 13 || CardNumber.Length == 16))
            {
                return true;
            }
            else if (CardNumber[0].Equals('3') && (CardNumber[1] == '4' || CardNumber[1] == '7'))
            {
                return true;
            }
            else return false;
        }
    }
}
