/************************************************************
    PROGRAMME  :  Classes Ex02 Rolling Dice

    OUTLINE    :  This programme prompts the user to click a
                  button to roll two dice, and displays the 
                  results in text and images.

    PROGRAMMER :  Fadi Chamas

    DATE       :  May 31st, 2020
 ************************************************************/
using ChamasF_ClassesEx02_RollDice.Properties;
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
namespace ChamasF_ClassesEx02_RollDice
{
    public partial class frmRollDice : Form
    {
        public frmRollDice()
        {
            InitializeComponent();
        }
        private void btnRollDice_Click(object sender, EventArgs e)
        {
            //declare variables
            int addition = 0;
            lstOutput.Items.Clear();
            Dice myDice = new Dice();
            PictureBox[] picArray = new PictureBox[] { pbOne, pbTwo, };
            //do twice
            for (int i = 0; i < 2; i++)
            {
                myDice.Roll(); //roll dice
                switch (myDice.FaceValue())
                {
                    //depending on dice value, output respective die
                    case 1: 
                        picArray[i].Image = Resources.Dice_1;
                        break;
                    case 2:
                        picArray[i].Image = Resources.Dice_2;
                        break;
                    case 3:
                        picArray[i].Image = Resources.Dice_3;
                        break;
                    case 4:
                        picArray[i].Image = Resources.Dice_4;
                        break;
                    case 5:
                        picArray[i].Image = Resources.Dice_5;
                        break;
                    case 6:
                        picArray[i].Image = Resources.Dice_6;
                        break;
                    default:
                        picArray[i].Image = Resources.Dice_1;
                        break;
                }
                lstOutput.Items.Add("Dice " + (i + 1) + ": " + myDice.FaceValue()); //output value of die in text
                addition += myDice.FaceValue(); //add die value together
            }
            lstOutput.Items.Add("");
            lstOutput.Items.Add("Sum of Dice: " + addition); //output total die value in text
        }
        public class Dice
        {
            int faceValue; //value of die
            public Dice()
            {
                faceValue = 1; //default equal to 1
            }
            public void Roll() //generate random number to "roll"
            {
                Random generator = new Random();
                faceValue = generator.Next(6) + 1;
            }
            public int FaceValue()
            {
                return faceValue; //return the random number
            }
            public override string ToString()
            {
                return faceValue.ToString(); //return it in words
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //close program
        }
    }
   
}
