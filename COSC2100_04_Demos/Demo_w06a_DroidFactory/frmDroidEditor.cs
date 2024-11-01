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
    public partial class frmDroidEditor : Form
    {

        #region Constructors

        private Droid droid;
            
        public frmDroidEditor()
        {
            InitializeComponent();
        }

        public frmDroidEditor(String droidDesignation)
        {
            InitializeComponent();

            droid = Droid.FindDroid(droidDesignation);

            if (droid != null) populateControls();
            else btnResetDroid.Enabled = false;
        }

        #endregion

        #region Custom Methods

        private void populateControls()
        {
            txtDesignation.Text = droid.Designation;
            lblDroidDesignation.Text = droid.Designation;
            chkInService.Checked = droid.IsInService;
            txtOwner.Text = droid.Owner;
            lblPrimaryColour.BackColor = droid.PrimaryColor;
            lblSecondaryColour.BackColor = droid.SecondaryColor;
        }

        #endregion

        #region Main Buttons

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetDroid_Click(object sender, EventArgs e)
        {
            populateControls();
        }

        private void btnSaveDroid_Click(object sender, EventArgs e)
        {
            droid.Designation = txtDesignation.Text;
            droid.IsInService = chkInService.Checked;
            droid.Owner = txtOwner.Text;
            droid.PrimaryColor = lblPrimaryColour.BackColor;
            droid.SecondaryColor = lblSecondaryColour.BackColor;

            this.Close();
        }

        #endregion

        private void btnSetPrimaryColour_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = lblPrimaryColour.BackColor;
            colorDialog1.ShowDialog();
            lblPrimaryColour.BackColor = colorDialog1.Color;
        }

        private void btnSecondaryColour_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = lblSecondaryColour.BackColor;
            colorDialog1.ShowDialog();
            lblSecondaryColour.BackColor = colorDialog1.Color;
        }
    }
}
