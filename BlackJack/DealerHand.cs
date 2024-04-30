using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms;

namespace BlackJack
{
    internal class DealerHand : Player
    {
        public DealerHand() : base()
        {
            
        }

        public override void PrintHand(ListBox dealBox)
        {
            dealBox.Items.Clear();
            dealBox.Items.Add("Dealer's Hand:");

            foreach (Card card in hand)
            {
                dealBox.Items.Add($"{card.Symbol} {card.SuitSymbol}");
            }

            dealBox.Items.Add($"Hand Value: {HandValue}");
        }

        public void RevealFirst(ListBox dealBox)
        {
            dealBox.Items.Clear();
            dealBox.Items.Add("Dealer's Hand:");
            if (hand.Count > 0)
            {
                Card firstCard = hand[0];
                dealBox.Items.Add($"{firstCard.Symbol} {firstCard.SuitSymbol}");
                if (firstCard.Value > 11)
                {
                    dealBox.Items.Add($"Hand Value: 10");
                }
                else
                {
                    dealBox.Items.Add($"Hand Value: {firstCard.Value}");
                }
            }
            else
            {
                dealBox.Items.Add("No cards in hand");
            }
        }
    }
}
