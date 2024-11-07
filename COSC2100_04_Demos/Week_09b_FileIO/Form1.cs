using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_09b_FileIO
{
    public partial class Form1 : Form
    {

        string savedContent = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // deal with the dialog first
            openFileDialog1.Filter = "Text Files|*.txt|CSV Files|*.csv";
            openFileDialog1.Title = "Open a file";
            openFileDialog1.FileName = txtFileName.Text;
            openFileDialog1.ShowDialog();
            txtFileName.Text = openFileDialog1.FileName;

            // open the file
            try
            {
                rtbContent.Text = MyFiles.OpenFile(txtFileName.Text);
                savedContent = rtbContent.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MyFiles.SaveFile(txtFileName.Text, rtbContent.Text);
                savedContent = rtbContent.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt|CSV Files|*.csv";
            saveFileDialog1.Title = "Save a file";  
            saveFileDialog1.FileName = txtFileName.Text;
            saveFileDialog1.ShowDialog();
            txtFileName.Text = saveFileDialog1.FileName;

            btnSave_Click(sender, e);
        }
    }
}