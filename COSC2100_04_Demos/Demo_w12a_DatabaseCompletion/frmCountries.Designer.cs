namespace Demo_w12a_DatabaseCompletion
{
    partial class frmCountries
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CountryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountryID,
            this.CountryName,
            this.RegionID});
            this.dataGridView1.Location = new System.Drawing.Point(75, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(653, 424);
            this.dataGridView1.TabIndex = 0;
            // 
            // CountryID
            // 
            this.CountryID.DataPropertyName = "CountryID";
            this.CountryID.HeaderText = "Country Code";
            this.CountryID.MaxInputLength = 2;
            this.CountryID.MinimumWidth = 8;
            this.CountryID.Name = "CountryID";
            this.CountryID.Width = 140;
            // 
            // CountryName
            // 
            this.CountryName.DataPropertyName = "CountryName";
            this.CountryName.HeaderText = "Name";
            this.CountryName.MaxInputLength = 50;
            this.CountryName.MinimumWidth = 8;
            this.CountryName.Name = "CountryName";
            this.CountryName.Width = 200;
            // 
            // RegionID
            // 
            this.RegionID.DataPropertyName = "RegionID";
            this.RegionID.HeaderText = "Region";
            this.RegionID.MaxInputLength = 1;
            this.RegionID.MinimumWidth = 8;
            this.RegionID.Name = "RegionID";
            this.RegionID.Width = 70;
            // 
            // frmCountries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 625);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCountries";
            this.Text = "frmCountries";
            this.Load += new System.EventHandler(this.frmCountries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegionID;
    }
}