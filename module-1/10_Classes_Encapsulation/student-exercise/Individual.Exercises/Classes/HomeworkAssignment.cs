using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {

        //constructor
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            SubmitterName = submitterName;
        }

        //Class properties
        public int EarnedMarks { get; set; }
        public int PossibleMarks { get;  }
        public string SubmitterName { get;  }
        public string LetterGrade { get { return NewLetterGrade(); } }

        //Methods
        public string NewLetterGrade()
        {
            double result = (double)EarnedMarks / PossibleMarks * 100;
            if (result >= 90)
            {
                return "A";
            }
            else if (result >= 80)
            {
                return "B";
            }
            else if (result >= 70)
            {
                return "C";
            }
            else if (result >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        



    }
}
