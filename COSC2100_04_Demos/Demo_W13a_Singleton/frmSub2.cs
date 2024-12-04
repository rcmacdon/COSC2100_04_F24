using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_W13a_Singleton
{
    public partial class frmSub2 : Form
    {

        private static frmSub2 instance;

        public static frmSub2 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new frmSub2();
                }
                return instance;
            }
        }

        private frmSub2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSub2_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}
