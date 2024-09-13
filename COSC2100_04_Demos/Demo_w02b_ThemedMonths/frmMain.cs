using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo_w02b_ThemedMonths
{
    public partial class frmMain : Form
    {

        #region GlobalVariables and Declarations


        #endregion

        #region Startup Items

        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulateControls();
            SetDefaults();
        }

        private void PopulateControls()
        {
            PopulateMonths();
        }

        private void PopulateMonths()
        {
            String[] months = {"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec" };

            foreach (string month in months) { 
                cboDateProg.Items.Add(month);
            }
        }

        /// <summary>
        /// Setting the default values for all controls on the form
        /// </summary>
        private void SetDefaults()
        {
            int mth = DateTime.Now.Month;
            if (cboDate.Items.Count >= mth) cboDate.SelectedIndex = mth - 1;
            if (cboDateProg.Items.Count >= mth) cboDateProg.SelectedIndex = mth - 1;


        }

        #endregion

        #region Constructors
   public frmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region Events
        /// <summary>
        /// Date combobox has the selected value changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetBackColor(cboDate.SelectedIndex);
        }
        #endregion  



        /// <summary>
        /// Changing the form background colour based on an input integer
        /// </summary>
        /// <param name="value">Typically an integer between 0 and 11</param>
        private void SetBackColor(int value)
        {
            switch (value)
            {
                case 0: this.BackColor = Color.White; break; // Jan
                case 1: this.BackColor = Color.Pink; break; // Feb
                case 2: this.BackColor = Color.LightGreen; break; // Mar
                case 3: this.BackColor = Color.Blue; break;
                case 4: this.BackColor = Color.Yellow; break;
                case 5: this.BackColor = Color.Maroon; break;
                case 6: this.BackColor = Color.Red; break;
                case 7: this.BackColor = Color.Brown; break;
                case 8: this.BackColor = Color.Gray; break;
                case 9: this.BackColor = Color.Orange; break;
                case 10: this.BackColor = Color.Black; break;
                case 11: this.BackColor = Color.Green; break;
                default: this.BackColor = Color.Silver; break;
            }
        }
    }
}
