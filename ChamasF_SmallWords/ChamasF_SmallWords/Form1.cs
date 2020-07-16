/***************************************************************
' PROGRAMME	: Strings Ex02 Small Words
'  
' OUTLINE : This programme reads the information from a file
'           named "smallwords.txt", and checks to see if any of
'           the letters in the inputted word, that is less than
'           5 characters, can spell out a word in the file. If
'           so, the programme displays the word from the file
'           in the listbox.
' 
' PROGRAMMER :	Fadi Chamas
'
' DATE	:	April 14th, 2020
' **************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ChamasF_SmallWords
{
    public partial class frmSmallWords : Form
    {
        public frmSmallWords()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            string strLetter = txtWords.Text;
            string strFile = " ";
            bool boolVerify = true;
            do
            {
                boolVerify = true;
                if (strLetter.Length != 5)
                {
                    MessageBox.Show("Word must be 5 letters!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    boolVerify = false;
                }
            } while (boolVerify == false);
            StreamReader srRead = new StreamReader("SmallWords.txt");
            while (srRead.Peek() > -1) 
            {
                strFile = srRead.ReadLine();
                if (strLetter.Contains(strFile[0]) && strLetter.Contains(strFile[1]) && strLetter.Contains(strFile[2])) 
                {
                    lstOutput.Items.Add(strFile);
                }
            }
        }
    }
}
