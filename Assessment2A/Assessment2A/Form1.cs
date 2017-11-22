using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment2A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //displaying the card 2Clubs
        private void btn2clubs_Click(object sender, EventArgs e)
        {
            pic2clubs.Visible = true;
        }

        //displaying the card 3Diamonds
        private void btn3diamonds_Click(object sender, EventArgs e)
        {
            pic3diamonds.Visible = true;
        }

        //displaying the card 4Spades
        private void btn4spades_Click(object sender, EventArgs e)
        {
            pic4spades.Visible = true;
        }

        //displaying the card 5Hearts
        private void btn5hearts_Click(object sender, EventArgs e)
        {
            pic5hearts.Visible = true;
        }

        //hide all cards
        private void btnreset_Click(object sender, EventArgs e)
        {
            pic2clubs.Visible = false;
            pic3diamonds.Visible = false;
            pic4spades.Visible = false;
            pic5hearts.Visible = false;
        }

        //close the application
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic2clubs_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
