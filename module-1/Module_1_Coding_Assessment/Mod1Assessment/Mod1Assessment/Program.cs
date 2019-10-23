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
            //string manufacturer = "Simons";
            //decimal deposits = 30.00M;
            //decimal withdrawal = 10.00M;
            //string cardNumber = "5738586394958384";
            //calling new instance of TellerMachine as newTellerMachine
            //TellerMachine newTellerMachine = new TellerMachine(manufacturer, deposits, withdrawal, cardNumber)
            //{

            //};
            //Printing out results of methods called from TellerMachine on newTellerMachine.
            //Console.WriteLine(newTellerMachine.Balance());
            //Console.WriteLine(newTellerMachine.CardValid(cardNumber));
            //Console.WriteLine($"ATM - {manufacturer} - {newTellerMachine.Balance()}");
            //Using StreamReader to read in contents of csv file and assing as string line.
            decimal totalSum = 0;
            List<TellerMachine> atmList = new List<TellerMachine>();
            using (StreamReader st = new StreamReader(@"..\..\..\Data\TellerInput.csv"))
            {
                while (!st.EndOfStream)
                {
                    string line = st.ReadLine();
                    string[] values = line.Split(", ");

                    string manufacturer = values[0];
                    decimal deposits = decimal.Parse(values[1]);
                    decimal withdrawal = decimal.Parse(values[2]);
                    string cardNumber = "5738586394958384";


                    TellerMachine newTellerMachine = new TellerMachine(manufacturer, deposits, withdrawal, cardNumber);
                    atmList.Add(newTellerMachine);
                    Console.WriteLine(newTellerMachine.ToString()); //writing overriden ToString on newTellerMachine

                    //Console.WriteLine($"{cardNumber} is a valid card number: {newTellerMachine.CardValid(cardNumber)}");
                    //Console.WriteLine($"ATM - {manufacturer} - Balance:{newTellerMachine.Balance}\n");
                    totalSum += newTellerMachine.Balance; 


                }
                
                Console.WriteLine($"\n ATM Machines TOTAL BALANCE: {totalSum:c}");
            }
            //
            


            Console.ReadLine();


        }
    }
}
