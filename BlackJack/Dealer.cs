using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace BlackJack
{
    internal class Dealer
    {
        private Player Dealerhand = new Player();
        private Player Playerhand = new Player();
        private Deck Cards = new Deck();
        private ListBox DealerBox = new ListBox();
        private ListBox PlayerBox = new ListBox();
        public Dealer(ListBox DBox, ListBox PBox) {

            Cards.Shuffle();
            this.DealerBox = DBox;
            this.PlayerBox = PBox;
        }
        public void DealCards()
        {
            Playerhand.ClearHands();
            Dealerhand.ClearHands();
            Dealerhand.Hit(Cards.Deal());
            Playerhand.Hit(Cards.Deal());
            Dealerhand.Hit(Cards.Deal());
            Playerhand.Hit(Cards.Deal());
            if (Dealerhand.HandValue == 21 || Playerhand.HandValue==21)
            {
                Dealerhand.DPrintHand(DealerBox);
                Playerhand.PPrintHand(PlayerBox);
                DecideWinner();
            }
            Dealerhand.RevealFirst(DealerBox);
            Playerhand.PPrintHand(PlayerBox);
        }
        public void PlayTurn()
        {
            Dealerhand.DPrintHand(DealerBox);
            while (Dealerhand.HandValue < 17)
            {
                Dealerhand.Hit(Cards.Deal());
                if (Dealerhand.HandValue > 21 && Dealerhand.AceCount > 0)
                {
                    Dealerhand.HandValue = Dealerhand.HandValue - 10;
                    Dealerhand.AceCount--;
                }
                Dealerhand.DPrintHand(DealerBox);
              

            }
            DecideWinner();

        }
        private void DecideWinner()
        {
            if (Dealerhand.HandValue == Playerhand.HandValue && Dealerhand.HandValue < 22)
            {
                MessageBox.Show("Push", "Tie", MessageBoxButtons.OK);

            }
            else if (Dealerhand.HandValue > Playerhand.HandValue && Dealerhand.HandValue<22 || Playerhand.HandValue>21)
            {
                MessageBox.Show("You LOSE", "LOL", MessageBoxButtons.OK);

            }
            else {
                MessageBox.Show("You WIN", "GGS", MessageBoxButtons.OK);

            }
            Playerhand.ClearHands();
            Dealerhand.ClearHands();
            DealCards();
        }
        public void PlayerHit()
        {
            Playerhand.Hit(Cards.Deal());
            if (Playerhand.HandValue > 21 && Playerhand.AceCount > 0)
            {
                Playerhand.HandValue = Playerhand.HandValue - 10;
                Playerhand.AceCount--;
            }
            else if (Playerhand.HandValue > 21)
            {
                Playerhand.PPrintHand(PlayerBox);
                DecideWinner();
            }
            Playerhand.PPrintHand(PlayerBox);
            

        }

        
        
            
}
    }

