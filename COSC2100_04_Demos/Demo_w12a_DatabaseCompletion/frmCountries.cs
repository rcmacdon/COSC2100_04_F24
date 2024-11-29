using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_w12a_DatabaseCompletion
{
    public partial class frmCountries: Form
    {
        public frmCountries()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmCountries_Load(object sender, EventArgs e)
        {
            try { 
                Country.LoadCountries();

                dataGridView1.DataSource = Country.countries;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

    }
}
