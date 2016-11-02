using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        // random number generator
        Random randGen = new Random();
        // int value for score initialized to 10
        int reel1Value, reel2Value, reel3Value;

        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e) 
        {
            // get random values for each reel (store each in separate int variable)
            reel1Value = randGen.Next(1, 4);
            reel2Value = randGen.Next(1, 4);
            reel3Value = randGen.Next(1, 4);
            // check value of reel 1 with a switch statement and set appropriate image
            switch (reel1Value)
            {
                case 1:  //start scene  
                    reel1.Image = Properties.Resources.cherry_100x125;
                    break;
                case 2:
                    reel1.Image = Properties.Resources.diamond_100x125;
                    break;
                case 3:
                    reel1.Image = Properties.Resources._7_100x125;
                    break;
                default:
                    break;
            }

            switch (reel2Value)
            {
                case 1:  //start scene  
                    reel2.Image = Properties.Resources.cherry_100x125;
                    break;
                case 2:
                    reel2.Image = Properties.Resources.diamond_100x125;
                    break;
                case 3:
                    reel2.Image = Properties.Resources._7_100x125;
                    break;
                default:
                    break;
            }

            switch (reel3Value)
            {
                case 1:  //start scene  
                    reel3.Image = Properties.Resources.cherry_100x125;
                    break;
                case 2:
                    reel3.Image = Properties.Resources.diamond_100x125;
                    break;
                case 3:
                    reel3.Image = Properties.Resources._7_100x125;
                    break;
                default:
                    break;
            }



            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal. 
            // If yes show "winner" statement and add 3 to score.
            // If no show "play again" statement and subtract 1 from score.         
            if (
                

            // if score has reached 0 display "lose" message and set button enabled property to false


            // display updated score

        }
    }
}
