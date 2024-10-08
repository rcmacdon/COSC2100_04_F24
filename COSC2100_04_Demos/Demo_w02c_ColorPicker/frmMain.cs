using System;

using System.Drawing;

using System.Windows.Forms;
using static Demo_w02c_ColorPicker.Settings;

namespace Demo_w02c_ColorPicker
{

    public partial class frmMain : Form
    {
        #region Startup
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
            this.nudNumSquares.Minimum = Settings.MIN_NUMSQUARES;
            this.nudNumSquares.Maximum = Settings.MAX_NUMSQUARES;
            this.nudNumSquares.Value = Settings.DEF_NUMSQUARES;
        }

        #endregion

        #region Custom Methods

        private void ProgWorkFlow(int num)
        {
            // Clear out old stuff
            ClearForm();
            // Create the new Squares
            CreateSquares(num);
            // Display the Squares
            DisplaySquares(num);
            // Resize the Form
            ResizeForm(num);
        }

        private void ClearForm()
        {
            foreach (Label label in Settings.labels) this.Controls.Remove(label);
        }

        private void CreateSquares(int numSquares)
        {

            for (int y = 0; y < numSquares; y++)
            {
                for (int x = 0; x < numSquares; x++)
                {
                    // Create Label
                    Label label = new Label();

                    // set properties
                    Color col = new Color();
                    col = Tools.RandomColor();
                    label.BackColor = col;
                    label.ForeColor = GetForeColor(col);

                    // size
                    label.Height = DEF_SQUARESIZE;
                    label.Width = DEF_SQUARESIZE;

                    // position
                    label.Top = DEF_TOPMARGIN + DEF_LAYOUTMARGIN + y * (DEF_SQUARESIZE + DEF_SPACING);
                    label.Left = DEF_LAYOUTMARGIN + x * (DEF_SQUARESIZE + DEF_SPACING);

                    // text
                    label.Text = "(" + col.R + "," + col.G + "," + col.B + ")";

                    // add click event handlers
                    label.Click += new System.EventHandler(this.label_Click);

                    // copy these properties to the label in the array
                    labels[x, y] = label;

                    }// end x
                } // end y
            }


            private void DisplaySquares(int numSquares)
            {
                for (int y = 0; y < numSquares; y++)
                {
                    for (int x = 0; x < numSquares; x++)
                    {
                        this.Controls.Add(Settings.labels[x, y]);
                    }
                }
            }

            private void ResizeForm(int numSquares)
            {
                this.Width = 2 * DEF_LAYOUTMARGIN + numSquares * DEF_SQUARESIZE + numSquares * DEF_SPACING;
                this.Height = this.Width + 2 * DEF_TOPMARGIN;
            }

            private Color GetForeColor(Color col)
            {
                double average = 0.0;
                average = ((double)col.R + (double)col.G + (double)col.B) / 3.0;

                if (average < 128) return Color.White;
                else return Color.Black;
            }
            #endregion

            #region General Events
            private void btnGo_Click(object sender, EventArgs e)
            {
                ProgWorkFlow((int)this.nudNumSquares.Value);
            }

            private void btnClear_Click(object sender, EventArgs e)
            {
                ClearForm();
                //TODO: write my Clint comment here
            }

            #endregion

            private void label_Click(object sender, EventArgs e)
            {
                Label lbl = (Label)sender;
                lbl.BackColor = Tools.RandomColor();
                lbl.ForeColor = GetForeColor(lbl.BackColor);
                lbl.Text = "(" + lbl.BackColor.R + "," + lbl.BackColor.G + "," + lbl.BackColor.B + ")";
            }
        }
    } 
