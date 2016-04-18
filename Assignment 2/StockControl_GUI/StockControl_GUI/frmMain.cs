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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //this adds all the other windows to the list of child forms of the current form and creates a new instance of the child forms.
        frmDispStock newDispStock = new frmDispStock();
        frmCaptureStock newCaptureStock = new frmCaptureStock();
        frmAbout newAbout = new frmAbout();

        private void frmMain_Load(object sender, EventArgs e)
        {
            newDispStock.MdiParent = this;
            newCaptureStock.MdiParent = this;
            newAbout.MdiParent = this;
        }

        private void displayStockLevelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open the display stock window.
            newDispStock.Show();
            newDispStock.Focus();
        }

        private void updateStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open the capture stock window.
            newCaptureStock.Show();
            newCaptureStock.Focus();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display the about window.
            newAbout.Show();
            newAbout.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit the program.
            Close();
        }
    }
}
