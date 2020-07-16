using ChamasF_ASSN03_TicTacToe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ChamasF_ASSN03_TicTacToe
{
    public partial class frmTicTacToe : Form
    {
        PictureBox[,] picCol = new PictureBox[3, 3];
        public frmTicTacToe()
        {
            InitializeComponent();
            picCol[0, 0] = pic1;
            picCol[0, 1] = pic2;
            picCol[0, 2] = pic3;
            picCol[1, 0] = pic4;
            picCol[1, 1] = pic5;
            picCol[1, 2] = pic6;
            picCol[2, 0] = pic7;
            picCol[2, 1] = pic8;
            picCol[2, 2] = pic9; 
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void PicClicked(object sender, EventArgs e)
        {
            PictureBox picClicked = (PictureBox)sender;
            picClicked.Image = currentplayer.playerImage;
        }
        void GameOver(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    picCol[i, j].Image = Resources.Blank;
                }
            }
        }
    }
}
