/************************************************************
    PROGRAMME  :  ASSN02 Letters In Word

    OUTLINE    :  This programme prompts the user to enter in
                  a word and then guess letters in the word
                  one by one. Once all the letters in the word
                  are guessed, the user is declared the winner
                  and the programme displays a message box 
                  showing all the guessed letters.

    PROGRAMMER :  Fadi Chamas

    DATE       :  April 17th, 2020
 ************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;
namespace ChamasF_ASSN02LettersInWord
{
    public partial class frmLettersinWord : Form
    {
        //declare variables
        bool[] boolCheck = new bool[25];
        int numCharacters = 0;
        string strFinish;
        public frmLettersinWord()
        {
            InitializeComponent();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //declare more variables
            string strWord = txtWord.Text.ToUpper();
            bool boolCheck = Regex.IsMatch(strWord, @"[^a-zA-Z]");
            //error checking, if nothing or not letter give error
            if (txtWord.Text == "")
            {
                MessageBox.Show("Invalid guess!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (boolCheck == true)
            {
                MessageBox.Show("Letters only!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //otherwise move on and display how many letters
            {
                txtWord.Enabled = false;
                btnEnter.Enabled = false;
                txtLetter.Enabled = true;
                lstOutput.Items.Add("\nThe word has " + strWord.Length + " letters.");
                this.AcceptButton = btnGuess;
                txtLetter.Focus();
            }
        }
        private void txtWord_TextChanged(object sender, EventArgs e)
        {
            if (txtWord.Text == "") // if nothing then dont let user move on
            {
                txtWord.BackColor = Color.White;
                btnEnter.Enabled = false;
            }
            else
            {
                txtWord.BackColor = Color.Yellow;
                btnEnter.Enabled = true;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //close program
        }
        private void CheckLetter(string guess)
        {
            //declare variables
            int intCharacters = 0;
            string strWord = txtWord.Text.ToUpper();
            //check winner
            for (int j = 0; j < strWord.Length; j++)
            {
                if (guess == strWord[j].ToString())
                {
                    intCharacters++;
                    numCharacters++;
                }
            }
            //compare letters to letter guessed
            for (int i = 0; i < 25; i++)
            {
                string asciichar = (Convert.ToChar(65 + i)).ToString();
                if (guess == asciichar)
                {
                    if (boolCheck[i] == true) //error checking, if letter already used show error
                    {
                        MessageBox.Show("Letter has already been used!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        boolCheck[i] = true;
                        lstOutput.Items.Add("The letter " + Convert.ToChar(65 + i).ToString() + " appears " + intCharacters + " times.");
                    }
                }
            }
            if (strWord.Length == numCharacters) //if winner prompt winner
            {
                lstOutput.Items.Add("Winner! You have guessed all the of the letters. The word was: ");
                lstOutput.Items.Add(" ");
                lstOutput.Items.Add(strWord);
                numCharacters = 0;
                btnGuess.Enabled = false;
                btnFinish.Enabled = true;
                this.AcceptButton = btnFinish;
            }
        }
        private void DisplayLettersGuessed()
        {
            for (int i = 0; i < 25; i++) //show letters guessed
            {
                if (boolCheck[i] == true)
                {
                    strFinish += " " + Convert.ToChar(65 + i).ToString() + ",";
                }
            }
            MessageBox.Show("Letters guessed:" + strFinish);
        }
        private void txtLetter_TextChanged(object sender, EventArgs e)
        {
            btnGuess.Enabled = true; //enable guess
        }
        private void btnGuess_Click(object sender, EventArgs e)
        {
            //declare variables
            string strLetter = txtLetter.Text.ToUpper();
            bool boolCheck = Regex.IsMatch(strLetter, @"[^a-zA-Z]");
            if (txtLetter.Text == "") //if nothing then dont let them move on and produce error
            {
                MessageBox.Show("Invalid guess!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (boolCheck == true) //only shows up if no letters
            {
                MessageBox.Show("Letters only!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CheckLetter(strLetter);
            }
            txtLetter.Clear();
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {
            DisplayLettersGuessed();
            //reset everything
            btnFinish.Enabled = false;
            btnGuess.Enabled = false;
            txtLetter.Enabled = false;
            txtWord.Enabled = true;
            txtWord.BackColor = Color.White;
            lstOutput.Items.Clear();
            btnEnter.Enabled = false;
            txtLetter.Clear();
            txtWord.Clear();
            numCharacters = 0;
            strFinish = null;
            for (int i = 0; i < 25; i++)
            {
                boolCheck[i] = false;
            }
            this.AcceptButton = btnEnter;
        }
    }
}