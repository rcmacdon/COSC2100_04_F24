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
    public partial class Form1 : Form
    {

        public static String MyString { get; set; }
        public ToolStripLabel tsMyString;

        public Form1()
        {
            InitializeComponent();
            tsMyString = tsLblMyString;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubForm frm = new frmSubForm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
