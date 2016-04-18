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
    public partial class frmCaptureStock : Form
    {
        public frmCaptureStock()
        {
            InitializeComponent();
        }

        private void frmCaptureStock_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close the window.
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("product information you enter will save, once this functionality is implemented in assginment 3");
        }
    }
}
