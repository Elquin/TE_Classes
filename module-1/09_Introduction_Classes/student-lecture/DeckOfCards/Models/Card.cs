using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Models
{
    public class Card
    {
        /// <summary>
        /// Create a new card object
        /// </summary>
        /// <param name="rank">Value of card, from 1-13</param>
        /// <param name="suit">Suit of card</param>
        public Card(int rank, string suit)
        {
            this.Rank = rank;
            Suit = suit;
            IsFaceUp = false;
        }

        /// <summary>
        /// creates a new Card and lets you specify up/down
        /// </summary>
        /// <param name="rank">Value of card, from 1-13</param>
        /// <param name="suit">Suit of card</param>
        /// <param name="isFaceUp">True if face is showing</param>
        public Card(int rank, string suit, bool isFaceUp)
        {
            this.Rank = rank;
            Suit = suit;
            IsFaceUp = isFaceUp;
        }

        /// <summary>
        /// Value of the card from Ace (1) through King (13)
        /// </summary>
        public int Rank { get; set; }

        private string suit;
        /// <summary>
        /// "Hearts", "Diamonds", "Spade", or "Clubs"
        /// </summary>
        public string Suit
        {
            get
            {
                return suit;
            }
            set
            {
                if (value.ToLower() == "hearts")
                {
                    suit = "Hearts";
                }
                else if (value.ToLower() == "diamonds")
                {
                    suit = "Diamonds";
                }
                else if (value.ToLower() == "clubs")
                {
                    suit = "Clubs";
                }
                else if (value.ToLower() == "spades")
                {
                    suit = "Spades";
                }
                else
                {
                    //We did not get a valid value
                    throw new ArgumentException("Invalid suit value");
                }
            }
        }

        /// <summary>
        /// True if the face of the card is showing
        /// </summary>
        public bool IsFaceUp { get; set; }


        /// <summary>
        /// Derived property showing the color of the card (derived from suit)
        /// </summary>
        public string Color
        {
            get
            {
                if (Suit.ToLower() == "hearts" || Suit.ToLower() == "diamonds")
                {
                    return "Red";
                }
                return "Black";
            }
        }

        public object Title { get; internal set; }
    }
}
