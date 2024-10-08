namespace ClassExercise1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnIceCream = new System.Windows.Forms.Button();
            this.btnGuessTheNumber = new System.Windows.Forms.Button();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.panGuessTheNumber = new System.Windows.Forms.Panel();
            this.nudGTNNumGuesses = new System.Windows.Forms.NumericUpDown();
            this.nudGTNRandomNumber = new System.Windows.Forms.NumericUpDown();
            this.lbl_GTN_Output = new System.Windows.Forms.Label();
            this.btn_GTN_Guess = new System.Windows.Forms.Button();
            this.gbx_GTN_Settings = new System.Windows.Forms.GroupBox();
            this.lblGTNMaximum = new System.Windows.Forms.Label();
            this.cbo_GTN_Difficulty = new System.Windows.Forms.ComboBox();
            this.lblGTNMaximumLabel = new System.Windows.Forms.Label();
            this.lbl_GTN_Difficulty = new System.Windows.Forms.Label();
            this.lblGTNMinimum = new System.Windows.Forms.Label();
            this.lblGTNMinimumLabel = new System.Windows.Forms.Label();
            this.lbl_GTN_Title = new System.Windows.Forms.Label();
            this.lblGuessedNumber = new System.Windows.Forms.Label();
            this.nudGuessedNumber = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.panMenu.SuspendLayout();
            this.panGuessTheNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNNumGuesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNRandomNumber)).BeginInit();
            this.gbx_GTN_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuessedNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panMenu.BackColor = System.Drawing.Color.Black;
            this.panMenu.Controls.Add(this.btnIceCream);
            this.panMenu.Controls.Add(this.btnGuessTheNumber);
            this.panMenu.Controls.Add(this.lblMenuTitle);
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(157, 741);
            this.panMenu.TabIndex = 0;
            // 
            // btnIceCream
            // 
            this.btnIceCream.Location = new System.Drawing.Point(10, 180);
            this.btnIceCream.Name = "btnIceCream";
            this.btnIceCream.Size = new System.Drawing.Size(137, 61);
            this.btnIceCream.TabIndex = 2;
            this.btnIceCream.Text = "&Ice Cream";
            this.btnIceCream.UseVisualStyleBackColor = true;
            // 
            // btnGuessTheNumber
            // 
            this.btnGuessTheNumber.Location = new System.Drawing.Point(10, 113);
            this.btnGuessTheNumber.Name = "btnGuessTheNumber";
            this.btnGuessTheNumber.Size = new System.Drawing.Size(137, 61);
            this.btnGuessTheNumber.TabIndex = 1;
            this.btnGuessTheNumber.Text = "&Guess The Number";
            this.toolTips.SetToolTip(this.btnGuessTheNumber, "Play Guess the Number game (alt-G)");
            this.btnGuessTheNumber.UseVisualStyleBackColor = true;
            this.btnGuessTheNumber.Click += new System.EventHandler(this.btnGuessTheNumber_Click);
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMenuTitle.Location = new System.Drawing.Point(7, 8);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(142, 97);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "My Little Games";
            this.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panGuessTheNumber
            // 
            this.panGuessTheNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panGuessTheNumber.Controls.Add(this.nudGTNNumGuesses);
            this.panGuessTheNumber.Controls.Add(this.nudGTNRandomNumber);
            this.panGuessTheNumber.Controls.Add(this.lbl_GTN_Output);
            this.panGuessTheNumber.Controls.Add(this.btn_GTN_Guess);
            this.panGuessTheNumber.Controls.Add(this.gbx_GTN_Settings);
            this.panGuessTheNumber.Controls.Add(this.lbl_GTN_Title);
            this.panGuessTheNumber.Controls.Add(this.lblGuessedNumber);
            this.panGuessTheNumber.Controls.Add(this.nudGuessedNumber);
            this.panGuessTheNumber.Location = new System.Drawing.Point(163, 12);
            this.panGuessTheNumber.Name = "panGuessTheNumber";
            this.panGuessTheNumber.Size = new System.Drawing.Size(667, 676);
            this.panGuessTheNumber.TabIndex = 1;
            this.panGuessTheNumber.Visible = false;
            // 
            // nudGTNNumGuesses
            // 
            this.nudGTNNumGuesses.Enabled = false;
            this.nudGTNNumGuesses.Location = new System.Drawing.Point(32, 356);
            this.nudGTNNumGuesses.Name = "nudGTNNumGuesses";
            this.nudGTNNumGuesses.Size = new System.Drawing.Size(120, 26);
            this.nudGTNNumGuesses.TabIndex = 6;
            // 
            // nudGTNRandomNumber
            // 
            this.nudGTNRandomNumber.Location = new System.Drawing.Point(32, 324);
            this.nudGTNRandomNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGTNRandomNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGTNRandomNumber.Name = "nudGTNRandomNumber";
            this.nudGTNRandomNumber.Size = new System.Drawing.Size(120, 26);
            this.nudGTNRandomNumber.TabIndex = 5;
            this.nudGTNRandomNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_GTN_Output
            // 
            this.lbl_GTN_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GTN_Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_GTN_Output.Location = new System.Drawing.Point(16, 431);
            this.lbl_GTN_Output.Name = "lbl_GTN_Output";
            this.lbl_GTN_Output.Size = new System.Drawing.Size(628, 202);
            this.lbl_GTN_Output.TabIndex = 3;
            // 
            // btn_GTN_Guess
            // 
            this.btn_GTN_Guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GTN_Guess.Location = new System.Drawing.Point(157, 252);
            this.btn_GTN_Guess.Name = "btn_GTN_Guess";
            this.btn_GTN_Guess.Size = new System.Drawing.Size(179, 138);
            this.btn_GTN_Guess.TabIndex = 4;
            this.btn_GTN_Guess.Text = "Guess";
            this.btn_GTN_Guess.UseVisualStyleBackColor = true;
            this.btn_GTN_Guess.Click += new System.EventHandler(this.btn_GTN_Guess_Click);
            // 
            // gbx_GTN_Settings
            // 
            this.gbx_GTN_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_GTN_Settings.Controls.Add(this.lblGTNMaximum);
            this.gbx_GTN_Settings.Controls.Add(this.cbo_GTN_Difficulty);
            this.gbx_GTN_Settings.Controls.Add(this.lblGTNMaximumLabel);
            this.gbx_GTN_Settings.Controls.Add(this.lbl_GTN_Difficulty);
            this.gbx_GTN_Settings.Controls.Add(this.lblGTNMinimum);
            this.gbx_GTN_Settings.Controls.Add(this.lblGTNMinimumLabel);
            this.gbx_GTN_Settings.Location = new System.Drawing.Point(22, 71);
            this.gbx_GTN_Settings.Name = "gbx_GTN_Settings";
            this.gbx_GTN_Settings.Size = new System.Drawing.Size(628, 100);
            this.gbx_GTN_Settings.TabIndex = 3;
            this.gbx_GTN_Settings.TabStop = false;
            this.gbx_GTN_Settings.Text = "Settings";
            // 
            // lblGTNMaximum
            // 
            this.lblGTNMaximum.AutoSize = true;
            this.lblGTNMaximum.Location = new System.Drawing.Point(356, 52);
            this.lblGTNMaximum.Name = "lblGTNMaximum";
            this.lblGTNMaximum.Size = new System.Drawing.Size(27, 20);
            this.lblGTNMaximum.TabIndex = 8;
            this.lblGTNMaximum.Text = "10";
            // 
            // cbo_GTN_Difficulty
            // 
            this.cbo_GTN_Difficulty.FormattingEnabled = true;
            this.cbo_GTN_Difficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cbo_GTN_Difficulty.Location = new System.Drawing.Point(81, 30);
            this.cbo_GTN_Difficulty.Name = "cbo_GTN_Difficulty";
            this.cbo_GTN_Difficulty.Size = new System.Drawing.Size(121, 28);
            this.cbo_GTN_Difficulty.TabIndex = 0;
            this.cbo_GTN_Difficulty.SelectedIndexChanged += new System.EventHandler(this.cbo_GTN_Difficulty_SelectedIndexChanged);
            // 
            // lblGTNMaximumLabel
            // 
            this.lblGTNMaximumLabel.AutoSize = true;
            this.lblGTNMaximumLabel.Location = new System.Drawing.Point(242, 52);
            this.lblGTNMaximumLabel.Name = "lblGTNMaximumLabel";
            this.lblGTNMaximumLabel.Size = new System.Drawing.Size(76, 20);
            this.lblGTNMaximumLabel.TabIndex = 7;
            this.lblGTNMaximumLabel.Text = "Maximum";
            // 
            // lbl_GTN_Difficulty
            // 
            this.lbl_GTN_Difficulty.AutoSize = true;
            this.lbl_GTN_Difficulty.Location = new System.Drawing.Point(6, 33);
            this.lbl_GTN_Difficulty.Name = "lbl_GTN_Difficulty";
            this.lbl_GTN_Difficulty.Size = new System.Drawing.Size(69, 20);
            this.lbl_GTN_Difficulty.TabIndex = 1;
            this.lbl_GTN_Difficulty.Text = "Difficulty";
            // 
            // lblGTNMinimum
            // 
            this.lblGTNMinimum.AutoSize = true;
            this.lblGTNMinimum.Location = new System.Drawing.Point(356, 22);
            this.lblGTNMinimum.Name = "lblGTNMinimum";
            this.lblGTNMinimum.Size = new System.Drawing.Size(18, 20);
            this.lblGTNMinimum.TabIndex = 6;
            this.lblGTNMinimum.Text = "1";
            // 
            // lblGTNMinimumLabel
            // 
            this.lblGTNMinimumLabel.AutoSize = true;
            this.lblGTNMinimumLabel.Location = new System.Drawing.Point(242, 22);
            this.lblGTNMinimumLabel.Name = "lblGTNMinimumLabel";
            this.lblGTNMinimumLabel.Size = new System.Drawing.Size(72, 20);
            this.lblGTNMinimumLabel.TabIndex = 5;
            this.lblGTNMinimumLabel.Text = "Minimum";
            // 
            // lbl_GTN_Title
            // 
            this.lbl_GTN_Title.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GTN_Title.Location = new System.Drawing.Point(14, 14);
            this.lbl_GTN_Title.Name = "lbl_GTN_Title";
            this.lbl_GTN_Title.Size = new System.Drawing.Size(316, 54);
            this.lbl_GTN_Title.TabIndex = 2;
            this.lbl_GTN_Title.Text = "Guess The Number";
            // 
            // lblGuessedNumber
            // 
            this.lblGuessedNumber.AutoSize = true;
            this.lblGuessedNumber.Location = new System.Drawing.Point(56, 202);
            this.lblGuessedNumber.Name = "lblGuessedNumber";
            this.lblGuessedNumber.Size = new System.Drawing.Size(129, 20);
            this.lblGuessedNumber.TabIndex = 1;
            this.lblGuessedNumber.Text = "Guess a Number";
            // 
            // nudGuessedNumber
            // 
            this.nudGuessedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGuessedNumber.Location = new System.Drawing.Point(191, 190);
            this.nudGuessedNumber.Name = "nudGuessedNumber";
            this.nudGuessedNumber.Size = new System.Drawing.Size(108, 39);
            this.nudGuessedNumber.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(755, 699);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 741);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panGuessTheNumber);
            this.Controls.Add(this.panMenu);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Little Games";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panMenu.ResumeLayout(false);
            this.panGuessTheNumber.ResumeLayout(false);
            this.panGuessTheNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNNumGuesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNRandomNumber)).EndInit();
            this.gbx_GTN_Settings.ResumeLayout(false);
            this.gbx_GTN_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuessedNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Button btnGuessTheNumber;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnIceCream;
        private System.Windows.Forms.Panel panGuessTheNumber;
        private System.Windows.Forms.Label lbl_GTN_Title;
        private System.Windows.Forms.Label lblGuessedNumber;
        private System.Windows.Forms.NumericUpDown nudGuessedNumber;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbx_GTN_Settings;
        private System.Windows.Forms.ComboBox cbo_GTN_Difficulty;
        private System.Windows.Forms.Label lbl_GTN_Difficulty;
        private System.Windows.Forms.Label lbl_GTN_Output;
        private System.Windows.Forms.Button btn_GTN_Guess;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Label lblGTNMaximum;
        private System.Windows.Forms.Label lblGTNMaximumLabel;
        private System.Windows.Forms.Label lblGTNMinimum;
        private System.Windows.Forms.Label lblGTNMinimumLabel;
        private System.Windows.Forms.NumericUpDown nudGTNRandomNumber;
        private System.Windows.Forms.NumericUpDown nudGTNNumGuesses;
    }
}

