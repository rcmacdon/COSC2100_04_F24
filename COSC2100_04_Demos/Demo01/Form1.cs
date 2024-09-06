using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo01
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hello World", "Clint was Here", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                btnHelloWorld.Text = "Yeah!";
            }

        }
    }
}
