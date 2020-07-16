using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamasF_ProvincePicker
{
    public partial class frmProvincePicker : Form
    {
        public frmProvincePicker()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstProvinces_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstProvinces.SelectedIndex)
            {
                case 0:
                    lblFact.Text = "Alberta Fact:\r\n\r\nHome of the Calgary Stampede";
                    break;
                case 1:
                    lblFact.Text = "British Columbia Fact:\r\n\r\nCanada's 3rd. largest Province.";
                    break;
                case 2:
                    lblFact.Text = "Manitoba Fact:\r\n\r\nKnown as Land of 100,000 Lakes.";
                    break;
                case 3:
                    lblFact.Text = "New Brunswick Fact:\r\n\r\nLargest of the three Canadian Maritime provinces.";
                    break;
                case 4:
                    lblFact.Text = "Newfoundland and Labrador Fact:\r\n\r\nCanada's most eastern province.";
                    break;
                case 5:
                    lblFact.Text = "Northwest Territories Fact:\r\n\r\nHas a consensus system of government with no political parties.";
                    break;
                case 6:
                    lblFact.Text = "Nova Scotia Fact:\r\n\r\nKnown for its high tides, lobster, fish, blueberries and apples.";
                    break;
                case 7:
                    lblFact.Text = "Nunavut Fact:\r\n\r\nBecame the largest and newer territory in Canada in 1999.";
                    break;
                case 8:
                    lblFact.Text = "Ontario Fact:\r\n\r\nAlmost 60 percent of all manufactured exports coming out of Canada comes from Ontario.";
                    break;
                case 9:
                    lblFact.Text = "Prince Edward Island Fact:\r\n\r\nFamous for red sand beaches, potatoes, and the irrepressible Anne of Green Gables.";
                    break;
                case 10:
                    lblFact.Text = "Quebec Fact:\r\n\r\nThe largest Canadian province in area, and the second largest in population.";
                    break;
                case 11:
                    lblFact.Text = "Saskatchewan Fact:\r\n\r\nThis province produces more than half the wheat grown in Canada";
                    break;
                case 12:
                    lblFact.Text = "Yukon Fact:\r\n\r\nThe Klondike Gold Rush changed this Canadian territory forever, but still more than 80 percent of Yukon is wild.";
                    break;
            } 
        }
    }
}
