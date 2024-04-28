﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    internal class Player
    {
        private List<Card> hand;
        public int CardCount { get; private set; } 
        public int HandValue { get; private set; } 

       
        public Player()
        {
            hand = new List<Card>();
            CardCount = 0;
            HandValue = 0;
        }

        
        public void Hit(Card newCard)
        {
            hand.Add(newCard); 
            CardCount++;
            if (newCard.Value > 11) 
            { 
                HandValue += 10;
            }
                
            else 
            {
                HandValue += newCard.Value;
            }
                
        }
        public void DPrintHand(ListBox dealBox)
        {
            dealBox.Items.Clear(); 
            dealBox.Items.Add("Dealer's Hand:");

            foreach (Card card in hand)
            {
                dealBox.Items.Add($"{card.Symbol} {card.SuitSymbol}");
            }

            dealBox.Items.Add($"Hand Value: {HandValue}");
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
        public void RevealFirst(ListBox dealBox)
        {
            dealBox.Items.Clear();
            dealBox.Items.Add("Dealer's Hand:");
            Card firstCard = hand[0];
            dealBox.Items.Add($"{firstCard.Symbol} {firstCard.SuitSymbol}");
            if (hand[0].Value > 11)
            {
                dealBox.Items.Add($"Hand Value: 10");
            }
            else
            {
                dealBox.Items.Add($"Hand Value: {hand[0].Value}");
            }
        }
    }
}