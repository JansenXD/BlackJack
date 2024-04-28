using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Deck
    {
        private List<Card> deck;

        public Deck()
        {
            deck = new List<Card>(); 

            for (int i = 0; i < 5; i++)// most casinos play with more than 1 deck to stop card counting
            {

                for (int suit = 1; suit <= 4; suit++)
                {
                    for (int rank = 2; rank <= 14; rank++)
                    {
                        deck.Add(new Card(rank, suit));
                    }
                }
            }
        }

        
        public void Shuffle()
        {
            Random rnd = new Random();
            for (int i = deck.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                Card temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }

        
        public Card Deal()
        {
            if (deck.Count == 0)
            {
                throw new InvalidOperationException("The deck is empty.");
            }
            Card dealtCard = deck[deck.Count - 1];
            deck.RemoveAt(deck.Count - 1);
            return dealtCard;
        }

    }

}
