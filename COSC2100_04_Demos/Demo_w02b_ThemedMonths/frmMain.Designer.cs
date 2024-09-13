namespace Demo_w02b_ThemedMonths
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mcaDate = new System.Windows.Forms.MonthCalendar();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cboDate = new System.Windows.Forms.ComboBox();
            this.cboDateProg = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mcaDate
            // 
            this.mcaDate.Location = new System.Drawing.Point(18, 18);
            this.mcaDate.Name = "mcaDate";
            this.mcaDate.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(387, 18);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDate.TabIndex = 1;
            // 
            // cboDate
            // 
            this.cboDate.FormattingEnabled = true;
            this.cboDate.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cboDate.Location = new System.Drawing.Point(387, 56);
            this.cboDate.Name = "cboDate";
            this.cboDate.Size = new System.Drawing.Size(200, 28);
            this.cboDate.TabIndex = 2;
            this.cboDate.SelectedIndexChanged += new System.EventHandler(this.cboDate_SelectedIndexChanged);
            // 
            // cboDateProg
            // 
            this.cboDateProg.FormattingEnabled = true;
            this.cboDateProg.Location = new System.Drawing.Point(387, 90);
            this.cboDateProg.Name = "cboDateProg";
            this.cboDateProg.Size = new System.Drawing.Size(200, 28);
            this.cboDateProg.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 403);
            this.Controls.Add(this.cboDateProg);
            this.Controls.Add(this.cboDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.mcaDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clint\'s Themed Months";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcaDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cboDate;
        private System.Windows.Forms.ComboBox cboDateProg;
    }
}

