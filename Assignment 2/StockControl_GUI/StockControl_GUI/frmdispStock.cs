using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl_GUI
{
    public partial class frmDispStock : Form
    {
        public frmDispStock()
        {
            InitializeComponent();
        }

        //resizes the window apropriatly dippending on the teb in view.
        private void tabPgDisplayStock_Click(object sender, EventArgs e)
        {
            this.Width = 735;
            this.Height = 536;
        }

        //resizes the window apropriatly dippending on the teb in view.
        private void tabPgDispStockOptions_Click(object sender, EventArgs e)
        {
            this.Width = 321;
            this.Height = 249;
        }

        //close the window once youre satisfied with the results.
        private void btnDispFinish_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void frnDispStock_Load(object sender, EventArgs e)
        {
            //removes all display filters on start up.
            chkDispUnitSold.Checked = true;
            chkViewProjctedIncome.Checked = true;
            chkDispIncomeRecieved.Checked = true;

            //code to display product information will be added here.
        }
    }
}
