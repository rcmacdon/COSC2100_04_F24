using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_w02a
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtElfName.Text.Trim().Length > 0)
            {
                lbxElves.Items.Add(txtElfName.Text.Trim());
                txtElfName.Clear();
            }
            else
            {
                MessageBox.Show("The Elf Name is Required!");
            }
        }

        private void lbxElves_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lbxElves.SelectedIndex;
            if (selectedIndex > -1)
            {
                String selectedString = lbxElves.Items[selectedIndex].ToString();
                txtElfName.Text = selectedString;
            }
        }

        private void btnUnselect_Click(object sender, EventArgs e)
        {
            lbxElves.SelectedItems.Clear();
            txtElfName.Clear();
        }
    }
}
