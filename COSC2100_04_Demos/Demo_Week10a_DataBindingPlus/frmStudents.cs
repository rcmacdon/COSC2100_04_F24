using Demo_Week10a_DataBindingPlus.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Week10a_DataBindingPlus
{
    public partial class frmStudents : Form
    {
        bool isLoading = true;

        public frmStudents()
        {
            InitializeComponent();
        }


        private void frmStudents_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmSplash frm = new frmSplash(this);
            frm.ShowDialog();

            Student.PopulateStudents(); 
            studentBindingSource.DataSource = Student.students;
            isLoading = false;
        }

        private void cboStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading)
            {
                Student s = (Student)cboStudents.SelectedItem;

                if (s != null)
                {
                    lblFirstName.Text = s.FirstName;
                    lblLastName.Text = s.LastName;
                    lblAge.Text = s.Age.ToString();
                    lblFullName.Text = s.ToString();
                    ssLblCurrentStudent.Text = s.ToString();
                } else
                {
                    lblFirstName.Text = string.Empty;
                    lblLastName.Text = string.Empty;
                    lblAge.Text = string.Empty;
                    lblFullName.Text = string.Empty;
                    ssLblCurrentStudent.Text = "- none -";
                }
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (cboStudents.Items.Count > 0) cboStudents.SelectedIndex = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (cboStudents.SelectedIndex > 0) cboStudents.SelectedIndex--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cboStudents.SelectedIndex < cboStudents.Items.Count - 1) cboStudents.SelectedIndex++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (cboStudents.Items.Count > 0) cboStudents.SelectedIndex = cboStudents.Items.Count - 1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboStudents.SelectedIndex >= 0)
            {
                Student s = (Student)cboStudents.SelectedItem;
                Student.students.Remove(s);
                cboStudents.SelectedIndex = 0;

                studentBindingSource.ResetBindings(false);
            }
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            frmDB frm = new frmDB();
            frm.ShowDialog();
        }
    }
}
