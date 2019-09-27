using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Employee
    {
        //constructor
        public Employee(int employeeId, string firstName, string lastName, double salary)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            AnnualSalary = salary;
            FullName = ($"{lastName}, {firstName}");

        }

        //Class properties
        public int EmployeeId { get; }
        public string FirstName { get;  }
        public string LastName { get; set; }
        public string FullName { get; }
        public string Department { get; set; }
        public double AnnualSalary { get; private set; }

        //Methods
        double percent = 5.5;
        public void RaiseSalary(double percent)
        {
            double raiseAmount = AnnualSalary * (percent / 100.00);
            AnnualSalary = (AnnualSalary + raiseAmount);
        }
        
    }
}
