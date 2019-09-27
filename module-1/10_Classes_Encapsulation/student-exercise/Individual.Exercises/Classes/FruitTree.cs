using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        //constructor
        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            TypeOfFruit = typeOfFruit;
            PiecesOfFruitLeft = startingPiecesOfFruit - PiecesOfFruitLeft;
            
        }

        //Class properties
        public string TypeOfFruit { get;  }
        public int PiecesOfFruitLeft { get; private set; }

        //Methods
        public bool PickFruit(int numberOfPiecesToRemove)
        {
            if (PiecesOfFruitLeft >= numberOfPiecesToRemove)
            {
                PiecesOfFruitLeft = PiecesOfFruitLeft - numberOfPiecesToRemove;
                return true; 
            }
            return false;
        }
    }
}
