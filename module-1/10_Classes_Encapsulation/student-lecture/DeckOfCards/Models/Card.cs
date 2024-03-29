﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Models
{
    public class Card
    {
        /// <summary>
        /// Creates new Card object
        /// </summary>
        /// <param name="rank">Value of card, from 1-13</param>
        /// <param name="suit">Suit of card</param>
        public Card(int rank, string suit)
        {
            this.Rank = rank;
            Suit = SetSuit(suit);
            IsFaceUp = false;
        }

        /// <summary>
        /// Given a string for the suit, validate and set the suit of this card.
        /// </summary>
        /// <param name="suitValue">Hearts, diamonds, spades or clubs</param>
        /// <returns>The proper name of the suit</returns>
        private string SetSuit(string suitValue)
        {
            string returnValue;
            if (suitValue.ToLower() == "hearts")
            {
                returnValue = "Hearts";
            }
            else if (suitValue.ToLower() == "diamonds")
            {
                returnValue = "Diamonds";
            }
            else if (suitValue.ToLower() == "clubs")
            {
                returnValue = "Clubs";
            }
            else if (suitValue.ToLower() == "spades")
            {
                returnValue = "Spades";
            }
            else
            {
                // We did not get a valid value
                throw new ArgumentException("Invalid suit value");
            }
            return returnValue;

        }

        /// <summary>
        /// Creates a new Card and lets you specify face up/down
        /// </summary>
        /// <param name="rank">Value of card, from 1-13</param>
        /// <param name="suit">Suit of card</param>
        /// <param name="isFaceUp">True if face is showing</param>
        public Card(int rank, string suit, bool isFaceUp)
        {
            this.Rank = rank;
            Suit = SetSuit(suit);
            IsFaceUp = isFaceUp;
        }

        /// <summary>
        /// Value of the card from Ace (1) through King (13)
        /// This is settable only through the constructor and then will never change
        /// during the lifetime of this object
        /// </summary>
        public int Rank { get;  }

        /// <summary>
        /// "Hearts", "Diamonds", "Spades", or "Clubs"
        /// </summary>
        public string Suit;
        

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

        /// <summary>
        /// Formal name of the card (e.g., "Ace of Spades")
        /// </summary>
        public string Title
        {
            get
            {
                string title = "";
                if (Rank > 1&& Rank < 11)
                {
                    title += Rank.ToString() + " ";
                }
                else if (Rank == 1)
                {
                    title += "Ace ";
                }
                else if (Rank == 11)
                {
                    title += "Jack ";
                }
                else if (Rank == 12)
                {
                    title += "Queen ";
                }
                else if (Rank == 13)
                {
                    title += "King ";
                }
                title += "of ";
                title += Suit;
                return title;
            }
        }

        /// <summary>
        /// Toggles the Face-up state of the card (or in English, turns the card over)
        /// </summary>
        public void Flip()
        {
            //Toggle the IsFaceUp property
            IsFaceUp = !IsFaceUp;

            //Long way of doing the above
            //if (IsFaceUp)
            //{
            //    IsFaceUp = false;
            //}
            //else
            //{
            //    IsFaceUp = true;
            //}
        }
    }
}
