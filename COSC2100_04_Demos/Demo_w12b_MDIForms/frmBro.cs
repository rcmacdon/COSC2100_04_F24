using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_w12b_MDIForms
{
    public partial class frmBro : Form
    {
        public frmBro()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBro_Activated(object sender, EventArgs e)
        {
            label1.Text = Form1.MyString;
        }
    }
}
