using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    internal class Player
    {
        public List<Card> hand;
        public int CardCount { get; private set; } 
        public int HandValue { get;  set; }
        public int AceCount { get; set; }


        public Player()
        {
            hand = new List<Card>();
            CardCount = 0;
            HandValue = 0;
            AceCount = 0;
        }

        
        public void Hit(Card newCard)
        {
            hand.Add(newCard); 
            CardCount++;
            if (newCard.Value > 11) 
            { 
                HandValue += 10;
            }
            else if (newCard.Value==11)
            {
                HandValue += newCard.Value;
                AceCount++;
            }
                
            else 
            {
                HandValue += newCard.Value;
            }
                
        }
       
        public void PPrintHand(ListBox dealBox)
        {
            dealBox.Items.Clear(); 
            dealBox.Items.Add("Player's Hand:");

            foreach (Card card in hand)
            {
                dealBox.Items.Add($"{card.Symbol} {card.SuitSymbol}");
            }

            dealBox.Items.Add($"Hand Value: {HandValue}");
        }
       
        public void ClearHands()
        {
            hand.Clear();
            CardCount = 0;
            HandValue = 0;
        }
        
    }
}
