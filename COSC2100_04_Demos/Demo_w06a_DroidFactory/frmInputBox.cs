using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_w06a_DroidFactory
{
    public partial class frmInputBox : Form
    {
        public String InputValue { get; private set; }


        public frmInputBox()
        {
            InitializeComponent();
        }

        public frmInputBox(String labelText)
        {
            InitializeComponent();
            lblTextString.Text = labelText;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Trim().Length > 0)
            {
                InputValue = txtInput.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
