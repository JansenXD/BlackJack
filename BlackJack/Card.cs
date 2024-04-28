using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{

   
    public class Card
    {
        private char[] cardSymbols = new char[13] { '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'A', 'J', 'Q', 'K' };
        private string[] SuitSymbols = new string[4] { "Clubs", "Diamonds", "Hearts", "Spades" };
        private char symbol;
        private int value;
        private int suit;
        private string suitsym;
        public Card (int value, int suit)
        {
            this.suitsym = SuitSymbols[suit - 1];
            this.symbol = cardSymbols[value-2];
            this.value = value;
            this.suit = suit;
            
        }
        public char Symbol
        {
            get { return symbol; }
        }

      
        public int Value
        {
            get { return value; }
        }

     
        public int Suit
        {
            get { return suit; }
        }

        public string SuitSymbol
        {
            get { return suitsym; }
        }

    }
}
