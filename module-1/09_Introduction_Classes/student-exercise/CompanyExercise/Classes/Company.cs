using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Company
    {


        //public Company(string name, int numberOfEmployees, decimal revenue, decimal expenses)
        //{
        //    Name = name;
        //    NumberOfEmployees = numberOfEmployees;
        //    Revenue = revenue;
        //    Expenses = expenses;
        //}
        public string Name { get; set; }
        public int NumberOfEmployees { get; set; }
        public decimal Revenue { get; set; }
        public decimal Expenses { get; set; }

        public string GetCompanySize()
        {
            if (NumberOfEmployees >= 250)
            {
                return "large";
            }
            else if (NumberOfEmployees >= 50 && NumberOfEmployees < 250)
            {
                return "medium";
            }
            else
            {
                return "small";
            }
        }

        // revenue - expenses

        public decimal GetProfit()
        {
            return Revenue - Expenses;
        }







    }
}


