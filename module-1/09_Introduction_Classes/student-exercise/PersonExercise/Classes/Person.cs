using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Person
    {
//FirstName string X   X The first name of the person.
//LastName string X   X The last name of the person.
//Age int X   X The age of the person.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //GetFullName()	string	Returns the first and last name 
        //of the person separated by a space. For instance "Sonny Koufax".

        public string GetFullName()
        {
            return ($"{FirstName} {LastName}");
        }

        //IsAdult()   bool Returns true if the person is 18 or older.

        public bool IsAdult()
        {
            if (Age >= 18)
            {
                return true;
            }
            else return false;
        }






    }
}
