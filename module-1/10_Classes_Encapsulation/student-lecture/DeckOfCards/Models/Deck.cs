using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Models
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();

        public Deck()
        {

            //Creating array just to cycle through w/ for loop
            string[] suits = new string[] { "Hearts", "Diamonds", "Spades", "Clubs" };
            //Outside loop cycles through each card rank
            for (int rank = 1; rank <= 13; rank++)
            {
                foreach (string suit in suits)
                {
                    Card card = new Card(rank, suit, false);
                    cards.Add(card);
                }
            }
        }
        public Card DealOne()
        {
            Card result = null;

            if (cards.Count > 0)
            {
                result = cards[0];
                cards.RemoveAt(0);
            }
            return result;
        }

        public void Shuffle()
        {
            List<Card> shuffledCards = new List<Card>();

            Random random = new Random();
            while (cards.Count > 0)
            {
                int randomIndex = random.Next(cards.Count);
                shuffledCards.Add(cards[randomIndex]);
                cards.RemoveAt(randomIndex);
            }
            cards = shuffledCards;
        }

    }
}
