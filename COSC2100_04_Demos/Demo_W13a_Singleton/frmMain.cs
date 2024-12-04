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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSubForm subForm = new frmSubForm();
            subForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmSubForm)
                {
                    f.Show();
                    f.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<frmSubForm> list = new List<frmSubForm>();

            foreach (Form f in Application.OpenForms)
            {
                if (f is frmSubForm)
                {
                    list.Add((frmSubForm)f);
                }
            }

            foreach (frmSubForm f in list)
            {
                f.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSub2.Instance.Show();
        }
    }
}
