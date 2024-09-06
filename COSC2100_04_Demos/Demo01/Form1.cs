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
            DialogResult myResult = MessageBox.Show("Hello World", "Clint was Here", MessageBoxButtons.YesNoCancel);
            // int i = 4;

            if (myResult == DialogResult.Yes) btnHelloWorld.Text = "Yeah!";
            else if (myResult == DialogResult.No) btnHelloWorld.Text = "Neah!";
            else btnHelloWorld.Text = "Cancelled!";


        }

        private void btnShowLabel_Click(object sender, EventArgs e)
        {
            CreateSaveLabel("Save Successful!");
        }

        private void CreateSaveLabel(String labelText)
        {
            Label lblSaveMessage = new Label();
            lblSaveMessage.Text = labelText;
            
            lblSaveMessage.Size = new Size(100,40);
            lblSaveMessage.Top = btnShowLabel.Top + btnShowLabel.Height/2;
            lblSaveMessage.Left = btnShowLabel.Left - 20 - lblSaveMessage.Width;

            this.Controls.Add(lblSaveMessage);

            // yeah it worked
        }
    }
}
