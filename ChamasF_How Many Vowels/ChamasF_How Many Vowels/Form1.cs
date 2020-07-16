/************************************************************
    PROGRAMME  :  Files Exercise 01

    OUTLINE    :  This programme prompts the user to enter in
                  a statement and returns how many vowels are
                  within the statement.

    PROGRAMMER :  Fadi Chamas

    DATE       :  April 10th, 2020
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
namespace ChamasF_How_Many_Vowels
{
    public partial class frmHowManyVowels : Form
    {
        public int intVowels; 
        public frmHowManyVowels()
        {
            InitializeComponent();
        }
        private void btnHowMany_Click(object sender, EventArgs e)
        {
            string strInput = Microsoft.VisualBasic.Interaction.InputBox("Enter a string: ", "How Many Vowels");
            IsVowel(strInput);
            lblOutput.Text = strInput + "\n\nString contains " + intVowels + " vowels.";
        }
        private void IsVowel(string strInput)
        {
            intVowels = 0;
            for (int i = 0; i <= strInput.Length - 1 ; i++)
            {
                strInput.ToLower();
                if (strInput[i] == 'a' || strInput[i] == 'e' || strInput[i] == 'i' || strInput[i] == 'o' || strInput[i] == 'u') 
                {
                    intVowels++;
                }
            }
        }
    }
}
