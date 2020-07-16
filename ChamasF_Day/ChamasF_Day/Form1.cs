using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamasF_Day
{
    public partial class frmDay : Form
    {
       
        Days myDay = new Days();
        public frmDay()
        {
            InitializeComponent();
        }
        
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            lblMain.Text = "Yesterday was: " + myDay.Previous(cbOne.Text);
        }

        private void cbOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMain.Text = "Today is: " + cbOne.Text;
        }
        class Days
        {
            string[] strDays = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            public string Previous(string cbOne)
            {
                int yesterday = 0;
                for (int i = 0; i < 7; i++)
                {
                    if (strDays[i] == cbOne)
                    {
                        yesterday = i - 1;
                        if (yesterday < 0)
                        {
                            yesterday = 6;
                        }

                    }
                }
                string theDay = strDays[yesterday];
                return theDay;
            }
            public string Tomorrow(string cbOne)
            {
                int tomorrow = 0;
                for (int i = 0; i < 7; i++)
                {
                    if (strDays[i] == cbOne)
                    {
                        tomorrow = i + 1;
                        if (tomorrow > 6)
                        {
                            tomorrow = 0;
                        }

                    }
                }
                string theDay = strDays[tomorrow];
                return theDay;
            }
            public string Add(string cbOne, int DaysAdd)
            {
                int add = 0;
                for (int i = 0; i < 7; i++)
                {
                    if (strDays[i] == cbOne)
                    {
                        add = i + DaysAdd;
                    }
                }
                return strDays[add % 7];
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            lblMain.Text = "Tomorrow is: " + myDay.Tomorrow(cbOne.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblMain.Text = txtAdd.Text + " days from now is/was " + myDay.Add(cbOne.Text, int.Parse(txtAdd.Text));
        }
    }
}
