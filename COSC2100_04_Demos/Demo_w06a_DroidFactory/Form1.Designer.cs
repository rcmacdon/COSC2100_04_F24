
namespace Demo_w06a_DroidFactory
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblOwnerLabel = new System.Windows.Forms.Label();
            this.btnResetDroid = new System.Windows.Forms.Button();
            this.btnSaveDroid = new System.Windows.Forms.Button();
            this.btnSecondaryColour = new System.Windows.Forms.Button();
            this.lblSecondaryColour = new System.Windows.Forms.Label();
            this.lblSecondColourLabel = new System.Windows.Forms.Label();
            this.btnSetPrimaryColour = new System.Windows.Forms.Button();
            this.lblPrimaryColour = new System.Windows.Forms.Label();
            this.chkDetailsInService = new System.Windows.Forms.CheckBox();
            this.lblDetailsDesignation = new System.Windows.Forms.Label();
            this.lboxDroids = new System.Windows.Forms.ListBox();
            this.lblColour1Label = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.lblDetailsOwner = new System.Windows.Forms.Label();
            this.lblDroidsTitle = new System.Windows.Forms.Label();
            this.chkInService = new System.Windows.Forms.CheckBox();
            this.colorDialogMain = new System.Windows.Forms.ColorDialog();
            this.lblDesignationLabel = new System.Windows.Forms.Label();
            this.lblDetailsSecondaryColour = new System.Windows.Forms.Label();
            this.lblDetailsPrimaryColour = new System.Windows.Forms.Label();
            this.grpDroidDetails = new System.Windows.Forms.GroupBox();
            this.btnSellDroid = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpSavedDroids = new System.Windows.Forms.GroupBox();
            this.grpCreator = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEditDroid = new System.Windows.Forms.Button();
            this.grpDroidDetails.SuspendLayout();
            this.grpSavedDroids.SuspendLayout();
            this.grpCreator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(21, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 59);
            this.label2.TabIndex = 6;
            this.label2.Text = "Primary Colour";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOwnerLabel
            // 
            this.lblOwnerLabel.AutoSize = true;
            this.lblOwnerLabel.Location = new System.Drawing.Point(21, 92);
            this.lblOwnerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnerLabel.Name = "lblOwnerLabel";
            this.lblOwnerLabel.Size = new System.Drawing.Size(64, 25);
            this.lblOwnerLabel.TabIndex = 2;
            this.lblOwnerLabel.Text = "Owner";
            // 
            // btnResetDroid
            // 
            this.btnResetDroid.Location = new System.Drawing.Point(22, 269);
            this.btnResetDroid.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetDroid.Name = "btnResetDroid";
            this.btnResetDroid.Size = new System.Drawing.Size(96, 51);
            this.btnResetDroid.TabIndex = 12;
            this.btnResetDroid.Text = "&Reset";
            this.btnResetDroid.UseVisualStyleBackColor = true;
            this.btnResetDroid.Click += new System.EventHandler(this.btnResetDroid_Click);
            // 
            // btnSaveDroid
            // 
            this.btnSaveDroid.Location = new System.Drawing.Point(427, 269);
            this.btnSaveDroid.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveDroid.Name = "btnSaveDroid";
            this.btnSaveDroid.Size = new System.Drawing.Size(136, 52);
            this.btnSaveDroid.TabIndex = 11;
            this.btnSaveDroid.Text = "&Save Droid";
            this.btnSaveDroid.UseVisualStyleBackColor = true;
            this.btnSaveDroid.Click += new System.EventHandler(this.btnSaveDroid_Click);
            // 
            // btnSecondaryColour
            // 
            this.btnSecondaryColour.Location = new System.Drawing.Point(472, 185);
            this.btnSecondaryColour.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecondaryColour.Name = "btnSecondaryColour";
            this.btnSecondaryColour.Size = new System.Drawing.Size(58, 51);
            this.btnSecondaryColour.TabIndex = 10;
            this.btnSecondaryColour.Text = "Set";
            this.btnSecondaryColour.UseVisualStyleBackColor = true;
            this.btnSecondaryColour.Click += new System.EventHandler(this.btnSecondaryColour_Click);
            // 
            // lblSecondaryColour
            // 
            this.lblSecondaryColour.BackColor = System.Drawing.Color.Gray;
            this.lblSecondaryColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecondaryColour.Location = new System.Drawing.Point(408, 185);
            this.lblSecondaryColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondaryColour.Name = "lblSecondaryColour";
            this.lblSecondaryColour.Size = new System.Drawing.Size(55, 51);
            this.lblSecondaryColour.TabIndex = 9;
            // 
            // lblSecondColourLabel
            // 
            this.lblSecondColourLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSecondColourLabel.Location = new System.Drawing.Point(300, 185);
            this.lblSecondColourLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondColourLabel.Name = "lblSecondColourLabel";
            this.lblSecondColourLabel.Size = new System.Drawing.Size(113, 69);
            this.lblSecondColourLabel.TabIndex = 8;
            this.lblSecondColourLabel.Text = "Secondary Colour";
            // 
            // btnSetPrimaryColour
            // 
            this.btnSetPrimaryColour.Location = new System.Drawing.Point(177, 185);
            this.btnSetPrimaryColour.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetPrimaryColour.Name = "btnSetPrimaryColour";
            this.btnSetPrimaryColour.Size = new System.Drawing.Size(58, 51);
            this.btnSetPrimaryColour.TabIndex = 7;
            this.btnSetPrimaryColour.Text = "Set";
            this.btnSetPrimaryColour.UseVisualStyleBackColor = true;
            this.btnSetPrimaryColour.Click += new System.EventHandler(this.btnSetPrimaryColour_Click);
            // 
            // lblPrimaryColour
            // 
            this.lblPrimaryColour.BackColor = System.Drawing.Color.Gray;
            this.lblPrimaryColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrimaryColour.Location = new System.Drawing.Point(113, 185);
            this.lblPrimaryColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimaryColour.Name = "lblPrimaryColour";
            this.lblPrimaryColour.Size = new System.Drawing.Size(55, 51);
            this.lblPrimaryColour.TabIndex = 6;
            // 
            // chkDetailsInService
            // 
            this.chkDetailsInService.AutoSize = true;
            this.chkDetailsInService.Enabled = false;
            this.chkDetailsInService.Location = new System.Drawing.Point(21, 57);
            this.chkDetailsInService.Margin = new System.Windows.Forms.Padding(4);
            this.chkDetailsInService.Name = "chkDetailsInService";
            this.chkDetailsInService.Size = new System.Drawing.Size(113, 29);
            this.chkDetailsInService.TabIndex = 1;
            this.chkDetailsInService.Text = "In Service";
            this.chkDetailsInService.UseVisualStyleBackColor = true;
            // 
            // lblDetailsDesignation
            // 
            this.lblDetailsDesignation.AutoSize = true;
            this.lblDetailsDesignation.Location = new System.Drawing.Point(21, 32);
            this.lblDetailsDesignation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailsDesignation.Name = "lblDetailsDesignation";
            this.lblDetailsDesignation.Size = new System.Drawing.Size(107, 25);
            this.lblDetailsDesignation.TabIndex = 0;
            this.lblDetailsDesignation.Text = "Designation";
            // 
            // lboxDroids
            // 
            this.lboxDroids.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lboxDroids.FormattingEnabled = true;
            this.lboxDroids.ItemHeight = 25;
            this.lboxDroids.Location = new System.Drawing.Point(14, 57);
            this.lboxDroids.Margin = new System.Windows.Forms.Padding(4);
            this.lboxDroids.Name = "lboxDroids";
            this.lboxDroids.Size = new System.Drawing.Size(181, 304);
            this.lboxDroids.TabIndex = 1;
            this.lboxDroids.SelectedIndexChanged += new System.EventHandler(this.lboxDroids_SelectedIndexChanged);
            // 
            // lblColour1Label
            // 
            this.lblColour1Label.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblColour1Label.Location = new System.Drawing.Point(22, 185);
            this.lblColour1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColour1Label.Name = "lblColour1Label";
            this.lblColour1Label.Size = new System.Drawing.Size(98, 69);
            this.lblColour1Label.TabIndex = 5;
            this.lblColour1Label.Text = "Primary Colour";
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(162, 109);
            this.txtOwner.Margin = new System.Windows.Forms.Padding(4);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(399, 37);
            this.txtOwner.TabIndex = 4;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOwner.Location = new System.Drawing.Point(22, 115);
            this.lblOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(64, 25);
            this.lblOwner.TabIndex = 3;
            this.lblOwner.Text = "Owner";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(162, 55);
            this.txtDesignation.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(207, 37);
            this.txtDesignation.TabIndex = 1;
            // 
            // lblDetailsOwner
            // 
            this.lblDetailsOwner.AutoSize = true;
            this.lblDetailsOwner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDetailsOwner.Location = new System.Drawing.Point(21, 117);
            this.lblDetailsOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailsOwner.Name = "lblDetailsOwner";
            this.lblDetailsOwner.Size = new System.Drawing.Size(68, 25);
            this.lblDetailsOwner.TabIndex = 3;
            this.lblDetailsOwner.Text = "Owner";
            // 
            // lblDroidsTitle
            // 
            this.lblDroidsTitle.AutoSize = true;
            this.lblDroidsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDroidsTitle.Location = new System.Drawing.Point(15, 35);
            this.lblDroidsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDroidsTitle.Name = "lblDroidsTitle";
            this.lblDroidsTitle.Size = new System.Drawing.Size(67, 25);
            this.lblDroidsTitle.TabIndex = 0;
            this.lblDroidsTitle.Text = "Droids";
            // 
            // chkInService
            // 
            this.chkInService.AutoSize = true;
            this.chkInService.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkInService.Location = new System.Drawing.Point(401, 61);
            this.chkInService.Margin = new System.Windows.Forms.Padding(4);
            this.chkInService.Name = "chkInService";
            this.chkInService.Size = new System.Drawing.Size(113, 29);
            this.chkInService.TabIndex = 2;
            this.chkInService.Text = "In Service";
            this.chkInService.UseVisualStyleBackColor = true;
            // 
            // lblDesignationLabel
            // 
            this.lblDesignationLabel.AutoSize = true;
            this.lblDesignationLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDesignationLabel.Location = new System.Drawing.Point(22, 60);
            this.lblDesignationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesignationLabel.Name = "lblDesignationLabel";
            this.lblDesignationLabel.Size = new System.Drawing.Size(107, 25);
            this.lblDesignationLabel.TabIndex = 0;
            this.lblDesignationLabel.Text = "Designation";
            // 
            // lblDetailsSecondaryColour
            // 
            this.lblDetailsSecondaryColour.BackColor = System.Drawing.Color.Gray;
            this.lblDetailsSecondaryColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDetailsSecondaryColour.Location = new System.Drawing.Point(187, 205);
            this.lblDetailsSecondaryColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailsSecondaryColour.Name = "lblDetailsSecondaryColour";
            this.lblDetailsSecondaryColour.Size = new System.Drawing.Size(55, 51);
            this.lblDetailsSecondaryColour.TabIndex = 9;
            // 
            // lblDetailsPrimaryColour
            // 
            this.lblDetailsPrimaryColour.BackColor = System.Drawing.Color.Gray;
            this.lblDetailsPrimaryColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDetailsPrimaryColour.Location = new System.Drawing.Point(29, 205);
            this.lblDetailsPrimaryColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailsPrimaryColour.Name = "lblDetailsPrimaryColour";
            this.lblDetailsPrimaryColour.Size = new System.Drawing.Size(55, 51);
            this.lblDetailsPrimaryColour.TabIndex = 8;
            // 
            // grpDroidDetails
            // 
            this.grpDroidDetails.Controls.Add(this.btnEditDroid);
            this.grpDroidDetails.Controls.Add(this.btnSellDroid);
            this.grpDroidDetails.Controls.Add(this.lblDetailsSecondaryColour);
            this.grpDroidDetails.Controls.Add(this.lblDetailsPrimaryColour);
            this.grpDroidDetails.Controls.Add(this.label3);
            this.grpDroidDetails.Controls.Add(this.label2);
            this.grpDroidDetails.Controls.Add(this.lblDetailsOwner);
            this.grpDroidDetails.Controls.Add(this.lblOwnerLabel);
            this.grpDroidDetails.Controls.Add(this.chkDetailsInService);
            this.grpDroidDetails.Controls.Add(this.lblDetailsDesignation);
            this.grpDroidDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpDroidDetails.Location = new System.Drawing.Point(219, 48);
            this.grpDroidDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpDroidDetails.Name = "grpDroidDetails";
            this.grpDroidDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpDroidDetails.Size = new System.Drawing.Size(345, 315);
            this.grpDroidDetails.TabIndex = 2;
            this.grpDroidDetails.TabStop = false;
            this.grpDroidDetails.Text = "Droid Details";
            // 
            // btnSellDroid
            // 
            this.btnSellDroid.BackColor = System.Drawing.Color.Navy;
            this.btnSellDroid.ForeColor = System.Drawing.Color.White;
            this.btnSellDroid.Location = new System.Drawing.Point(189, 260);
            this.btnSellDroid.Margin = new System.Windows.Forms.Padding(4);
            this.btnSellDroid.Name = "btnSellDroid";
            this.btnSellDroid.Size = new System.Drawing.Size(147, 47);
            this.btnSellDroid.TabIndex = 10;
            this.btnSellDroid.Text = "Sell Droid";
            this.btnSellDroid.UseVisualStyleBackColor = false;
            this.btnSellDroid.Click += new System.EventHandler(this.btnSellDroid_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(167, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 59);
            this.label3.TabIndex = 7;
            this.label3.Text = "Secondary Colour";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1092, 813);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 49);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpSavedDroids
            // 
            this.grpSavedDroids.BackColor = System.Drawing.Color.Transparent;
            this.grpSavedDroids.Controls.Add(this.grpDroidDetails);
            this.grpSavedDroids.Controls.Add(this.lboxDroids);
            this.grpSavedDroids.Controls.Add(this.lblDroidsTitle);
            this.grpSavedDroids.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpSavedDroids.Location = new System.Drawing.Point(30, 441);
            this.grpSavedDroids.Margin = new System.Windows.Forms.Padding(4);
            this.grpSavedDroids.Name = "grpSavedDroids";
            this.grpSavedDroids.Padding = new System.Windows.Forms.Padding(4);
            this.grpSavedDroids.Size = new System.Drawing.Size(595, 391);
            this.grpSavedDroids.TabIndex = 6;
            this.grpSavedDroids.TabStop = false;
            this.grpSavedDroids.Text = "Saved Droids";
            // 
            // grpCreator
            // 
            this.grpCreator.BackColor = System.Drawing.Color.Transparent;
            this.grpCreator.Controls.Add(this.btnResetDroid);
            this.grpCreator.Controls.Add(this.btnSaveDroid);
            this.grpCreator.Controls.Add(this.btnSecondaryColour);
            this.grpCreator.Controls.Add(this.lblSecondaryColour);
            this.grpCreator.Controls.Add(this.lblSecondColourLabel);
            this.grpCreator.Controls.Add(this.btnSetPrimaryColour);
            this.grpCreator.Controls.Add(this.lblPrimaryColour);
            this.grpCreator.Controls.Add(this.lblColour1Label);
            this.grpCreator.Controls.Add(this.txtOwner);
            this.grpCreator.Controls.Add(this.lblOwner);
            this.grpCreator.Controls.Add(this.chkInService);
            this.grpCreator.Controls.Add(this.txtDesignation);
            this.grpCreator.Controls.Add(this.lblDesignationLabel);
            this.grpCreator.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpCreator.Location = new System.Drawing.Point(30, 69);
            this.grpCreator.Margin = new System.Windows.Forms.Padding(4);
            this.grpCreator.Name = "grpCreator";
            this.grpCreator.Padding = new System.Windows.Forms.Padding(4);
            this.grpCreator.Size = new System.Drawing.Size(595, 353);
            this.grpCreator.TabIndex = 5;
            this.grpCreator.TabStop = false;
            this.grpCreator.Text = "Droid Creator";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(-4, -3);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1209, 51);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Droid Factory";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditDroid
            // 
            this.btnEditDroid.BackColor = System.Drawing.Color.Navy;
            this.btnEditDroid.ForeColor = System.Drawing.Color.White;
            this.btnEditDroid.Location = new System.Drawing.Point(8, 260);
            this.btnEditDroid.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditDroid.Name = "btnEditDroid";
            this.btnEditDroid.Size = new System.Drawing.Size(147, 47);
            this.btnEditDroid.TabIndex = 11;
            this.btnEditDroid.Text = "Edit Droid";
            this.btnEditDroid.UseVisualStyleBackColor = false;
            this.btnEditDroid.Click += new System.EventHandler(this.btnEditDroid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Demo_w06a_DroidFactory.Properties.Resources.R2D2_Modified;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1202, 871);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpSavedDroids);
            this.Controls.Add(this.grpCreator);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDroidDetails.ResumeLayout(false);
            this.grpDroidDetails.PerformLayout();
            this.grpSavedDroids.ResumeLayout(false);
            this.grpSavedDroids.PerformLayout();
            this.grpCreator.ResumeLayout(false);
            this.grpCreator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOwnerLabel;
        private System.Windows.Forms.Button btnResetDroid;
        private System.Windows.Forms.Button btnSaveDroid;
        private System.Windows.Forms.Button btnSecondaryColour;
        private System.Windows.Forms.Label lblSecondaryColour;
        private System.Windows.Forms.Label lblSecondColourLabel;
        private System.Windows.Forms.Button btnSetPrimaryColour;
        private System.Windows.Forms.Label lblPrimaryColour;
        private System.Windows.Forms.CheckBox chkDetailsInService;
        private System.Windows.Forms.Label lblDetailsDesignation;
        private System.Windows.Forms.ListBox lboxDroids;
        private System.Windows.Forms.Label lblColour1Label;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label lblDetailsOwner;
        private System.Windows.Forms.Label lblDroidsTitle;
        private System.Windows.Forms.CheckBox chkInService;
        private System.Windows.Forms.ColorDialog colorDialogMain;
        private System.Windows.Forms.Label lblDesignationLabel;
        private System.Windows.Forms.Label lblDetailsSecondaryColour;
        private System.Windows.Forms.Label lblDetailsPrimaryColour;
        private System.Windows.Forms.GroupBox grpDroidDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpSavedDroids;
        private System.Windows.Forms.GroupBox grpCreator;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSellDroid;
        private System.Windows.Forms.Button btnEditDroid;
    }
}