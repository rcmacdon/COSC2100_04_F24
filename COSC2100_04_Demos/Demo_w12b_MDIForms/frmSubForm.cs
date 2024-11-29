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
    public partial class frmSubForm : Form
    {
        public frmSubForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBro frm = new frmBro();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Form1.MyString = textBox1.Text;
            Form1 frm = (Form1)this.MdiParent;

            frm.tsMyString.Text = textBox1.Text;
        }
    }
}
