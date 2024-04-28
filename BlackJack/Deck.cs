using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Deck
    {
        private List<Card> deck;

        public Deck()
        {
            deck = new List<Card>(); // Initialize the class-level deck field

            // Populate the deck with cards
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int rank = 2; rank <= 14; rank++)
                {
                    deck.Add(new Card(rank, suit));
                }
            }
        }

        // Shuffle the deck using the Fisher-Yates algorithm
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

        // Deal a card from the deck
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

        // Print all cards in the deck (for debugging purposes)
        public void Print()
        {
            foreach (Card card in deck)
            {
                Console.WriteLine(card.SuitSymbol);
            }
        }
    }

}
