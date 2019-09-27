using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        //constructor
        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            PlaneNumber = planeNumber;
            TotalFirstClassSeats = totalFirstClassSeats;
            TotalCoachSeats = totalCoachSeats;

        }

        //Class properties
        public string PlaneNumber { get; }
        public int BookedFirstClassSeats { get; private set; }
        public int AvailableFirstClassSeats
        {
            get { return TotalFirstClassSeats - BookedFirstClassSeats; }
        }
        public int TotalFirstClassSeats { get; }
        public int BookedCoachSeats { get; private set; }
        public int AvailableCoachSeats
        {
            get
            {
                return TotalCoachSeats - BookedCoachSeats;
            }
        }
        public int TotalCoachSeats { get; }

        //Methods
        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if (forFirstClass)
            {
                if (AvailableFirstClassSeats >= totalNumberOfSeats)
                {
                    BookedFirstClassSeats += totalNumberOfSeats;
                    return true;
                }
                return false;
            }
            else
            {
                if (AvailableCoachSeats >= totalNumberOfSeats)
                {
                    BookedCoachSeats += totalNumberOfSeats;
                    return true;
                }
                return false;
            }

        }
    }
}
