namespace Demo_w02a
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
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lbxElves = new System.Windows.Forms.ListBox();
            this.lblElfList = new System.Windows.Forms.Label();
            this.txtElfName = new System.Windows.Forms.TextBox();
            this.lblElfName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUnselect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMainTitle.BackColor = System.Drawing.Color.Black;
            this.lblMainTitle.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.White;
            this.lblMainTitle.Location = new System.Drawing.Point(0, 1);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(460, 35);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "My Friendly Elves";
            this.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxElves
            // 
            this.lbxElves.FormattingEnabled = true;
            this.lbxElves.ItemHeight = 20;
            this.lbxElves.Location = new System.Drawing.Point(6, 82);
            this.lbxElves.Name = "lbxElves";
            this.lbxElves.Size = new System.Drawing.Size(169, 184);
            this.lbxElves.TabIndex = 3;
            this.lbxElves.SelectedIndexChanged += new System.EventHandler(this.lbxElves_SelectedIndexChanged);
            // 
            // lblElfList
            // 
            this.lblElfList.AutoSize = true;
            this.lblElfList.Location = new System.Drawing.Point(9, 51);
            this.lblElfList.Name = "lblElfList";
            this.lblElfList.Size = new System.Drawing.Size(94, 20);
            this.lblElfList.TabIndex = 2;
            this.lblElfList.Text = "List of Elves";
            // 
            // txtElfName
            // 
            this.txtElfName.Location = new System.Drawing.Point(347, 79);
            this.txtElfName.Name = "txtElfName";
            this.txtElfName.Size = new System.Drawing.Size(100, 26);
            this.txtElfName.TabIndex = 0;
            // 
            // lblElfName
            // 
            this.lblElfName.AutoSize = true;
            this.lblElfName.Location = new System.Drawing.Point(230, 82);
            this.lblElfName.Name = "lblElfName";
            this.lblElfName.Size = new System.Drawing.Size(111, 30);
            this.lblElfName.TabIndex = 4;
            this.lblElfName.Text = "Elf Name";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(371, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(290, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUnselect
            // 
            this.btnUnselect.Location = new System.Drawing.Point(108, 42);
            this.btnUnselect.Name = "btnUnselect";
            this.btnUnselect.Size = new System.Drawing.Size(92, 37);
            this.btnUnselect.TabIndex = 5;
            this.btnUnselect.Text = "Unselect";
            this.btnUnselect.UseVisualStyleBackColor = true;
            this.btnUnselect.Click += new System.EventHandler(this.btnUnselect_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(458, 277);
            this.Controls.Add(this.btnUnselect);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblElfName);
            this.Controls.Add(this.txtElfName);
            this.Controls.Add(this.lblElfList);
            this.Controls.Add(this.lbxElves);
            this.Controls.Add(this.lblMainTitle);
            this.MinimumSize = new System.Drawing.Size(480, 333);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Week 02 Demo A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.ListBox lbxElves;
        private System.Windows.Forms.Label lblElfList;
        private System.Windows.Forms.TextBox txtElfName;
        private System.Windows.Forms.Label lblElfName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUnselect;
    }
}

