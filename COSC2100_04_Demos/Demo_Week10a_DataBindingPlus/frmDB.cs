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
    public partial class frmDB : Form
    {
        public frmDB()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeSampleDataSetManagers.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter1.Fill(this.employeeSampleDataSetManagers.employees);
            // TODO: This line of code loads data into the 'employeeSampleDataSetDept.departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.employeeSampleDataSetDept.departments);
            // TODO: This line of code loads data into the 'employeeSampleDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeeSampleDataSet.employees);

        }

        private void DoMyMenuStuff(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked here");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
