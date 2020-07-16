/************************************************************
    PROGRAMME  :  Classes Ex01 Coin Flip

    OUTLINE    :  This programme prompts the user to click a
                  button to flip a coin five times, and
                  displays the results in text and images.

    PROGRAMMER :  Fadi Chamas

    DATE       :  May 31st, 2020
 ************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ChamasF_Classes_CoinFlip
{
    public partial class frmCoinFlip : Form
    {
        public frmCoinFlip()
        {
            InitializeComponent();
        }
        private void btnFlip_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear(); //clear list
            Coin myCoin = new Coin(); //declare class coin
            PictureBox[] picArray = new PictureBox[] {pbOne, pbTwo, pbThree, pbFour, pbFive}; //declare picturebox array
            ShowPic(myCoin, picArray); //call show pic sending coin value and picarray value
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //close
        }
        class Coin {
            private string sideUp;
            Random rand = new Random();
            public Coin()
            {
                sideUp = "Heads";
            }
            public void Flip()
            {
                //declare heads or tails randomly
                int value = rand.Next(2);
                if (value == 0) 
                {
                    sideUp = "Heads";
                }
                else
                {
                    sideUp = "Tails";
                }
            }
            public string GetSideUp()
            {
                return sideUp;
            }
        }
        private void ShowPic(Coin sent, PictureBox[] pic)
        {
            //depending on sent value, either heads or tails, if heads put heads in list box and display heads picture, otherwise put tails and display tails picture
            for (int i = 0; i < 5; i++)
            {
                sent.Flip();
                lstOutput.Items.Add(sent.GetSideUp());
                if (sent.GetSideUp() == "Heads")
                {
                    pic[i].Image = Properties.Resources.loonieHeads;
                }
                else
                {
                    pic[i].Image = Properties.Resources.loonieTails;
                }
            }
        }
    }
}
