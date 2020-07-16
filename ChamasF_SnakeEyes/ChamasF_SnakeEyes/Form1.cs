/************************************************************
    PROGRAMME  :  Classes Ex03 Snake Eyes

    OUTLINE    :  This programme prompts the user to click a
                  button to roll two dice, and displays the 
                  number of times two ones are rolled.

    PROGRAMMER :  Fadi Chamas

    DATE       :  May 31st, 2020
 ************************************************************/
using ChamasF_SnakeEyes.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ChamasF_SnakeEyes
{
    public partial class frmSnakeEyes : Form
    {
        public frmSnakeEyes()
        {
            InitializeComponent();
        }
        public class Dice
        {
            int faceValue; //value of die
            Random generator = new Random();
            public Dice()
            {
                faceValue = 1; //default equal to 1
            }
            public int Roll() //generate random number to "roll"
            {
                
                faceValue = generator.Next(6) + 1;
                return faceValue;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //close program
        }
        private void btnRoll_Click(object sender, EventArgs e)
        {
            //declare variables
            int same = 0;
            Dice myDice = new Dice();
            Dice hisDice = new Dice();
            for (int i = 0; i < int.Parse(txtNum.Text); i++)
            {
                if (myDice.Roll() == 1 && hisDice.Roll() == 1) //if dies are both equal to 1
                {
                    same++; //tally increases
                }
            }
            lblNum.Text = same.ToString(); //output tally
            lblPercentage.Text = String.Format("{0:P2}", (same / double.Parse(txtNum.Text))); //output equation
        }
    }

}
