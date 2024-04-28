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
            Dealerhand.Hit(Cards.Deal());
            Playerhand.Hit(Cards.Deal());
            Dealerhand.Hit(Cards.Deal());
            Playerhand.Hit(Cards.Deal());

            Dealerhand.RevealFirst(DealerBox);
            Playerhand.PPrintHand(PlayerBox);
        }
        public void PlayTurn()
        {
            Dealerhand.DPrintHand(DealerBox);
            while (Dealerhand.HandValue < 17)
            {
                Dealerhand.Hit(Cards.Deal());
                Dealerhand.DPrintHand(DealerBox);
                Thread.Sleep(1000);
                
            }
            DecideWinner();

        }
        private void DecideWinner()
        {
            if (Dealerhand.HandValue > Playerhand.HandValue)
            {
                MessageBox.Show("You LOSE", "LOL", MessageBoxButtons.OK);

            }
            else {
                MessageBox.Show("You WIN", "GGS", MessageBoxButtons.OK);

            }
        }
        
        
            
}
    }

