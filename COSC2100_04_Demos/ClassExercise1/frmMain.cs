/* **************************************
 * COSC2100 - Section 4 - Week 3
 * _________________
 * Sept 17, 2024
 * Week 3 - Demo A and Class Exercise 1
 * ***********************************  */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassExercise1
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetDefaults();

        }

        private void SetDefaults()
        {
            SetGTN_Defaults();
        }
        private void SetGTN_Defaults()
        {
            cbo_GTN_Difficulty.SelectedIndex = 0;
            nudGuessedNumber.Minimum = 1;
            SetGTNMaximum();
        }

        private void SetGTNMaximum()
        {
            switch (cbo_GTN_Difficulty.SelectedIndex)
            {
                case 1: 
                    nudGuessedNumber.Maximum = 100;
                    lblGTNMaximum.Text = "100"; 
                    break;
                case 2: 
                    nudGuessedNumber.Maximum = 1000;
                    lblGTNMaximum.Text = "1000"; 
                    break;
                default: 
                    nudGuessedNumber.Maximum = 10;
                    lblGTNMaximum.Text = "10"; 
                    break;
            }

            nudGTNRandomNumber.Value = Tools.RandomInt(1, (int)nudGuessedNumber.Maximum);

            nudGTNNumGuesses.Value = 0;

        }

        private void cbo_GTN_Difficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetGTNMaximum();
        }

        private void btnGuessTheNumber_Click(object sender, EventArgs e)
        {
            panGuessTheNumber.Visible = !panGuessTheNumber.Visible;
            SetGTN_Defaults();
        }

        private void btn_GTN_Guess_Click(object sender, EventArgs e)
        {
            nudGTNNumGuesses.Value += 1;

            // compare guess to value
            if (nudGuessedNumber.Value > nudGTNRandomNumber.Value)
            {
                lbl_GTN_Output.Text += "Guess " + nudGTNNumGuesses.Value + " is TOO HIGH!\n";
            }
            else if (nudGuessedNumber.Value < nudGTNRandomNumber.Value)
            {
                lbl_GTN_Output.Text += "Guess " + nudGTNNumGuesses.Value + " is TOO LOW!\n";
            }
            else
            {
                lbl_GTN_Output.Text += "YEAH! You got it!  It took you " + nudGTNNumGuesses.Value + " guesses\n";
            }
        }
    }
}
