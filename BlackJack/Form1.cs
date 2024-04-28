using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        private Dealer game;
        public Form1()
        {
            InitializeComponent();
            game = new Dealer(DealerBox, PlayerBox);
        }
        //DealButton
        private void button3_Click(object sender, EventArgs e)
        {
            
            game.DealCards();

        }

        private void Hitbutton_Click(object sender, EventArgs e)
        {

            game.PlayerHit();
            
        }

        private void Standbutton_Click(object sender, EventArgs e)
        {
           game.PlayTurn();
          
        }
        //double button
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
