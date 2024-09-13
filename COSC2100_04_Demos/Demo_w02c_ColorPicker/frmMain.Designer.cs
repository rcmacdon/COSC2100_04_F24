namespace Demo_w02c_ColorPicker
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
            this.nudNumSquares = new System.Windows.Forms.NumericUpDown();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumSquares)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumSquares
            // 
            this.nudNumSquares.Location = new System.Drawing.Point(12, 12);
            this.nudNumSquares.Name = "nudNumSquares";
            this.nudNumSquares.Size = new System.Drawing.Size(44, 26);
            this.nudNumSquares.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(63, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 32);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "&Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(144, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 32);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.nudNumSquares);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Week 2 Demo C - Color Picker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumSquares)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNumSquares;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnClear;
    }
}

