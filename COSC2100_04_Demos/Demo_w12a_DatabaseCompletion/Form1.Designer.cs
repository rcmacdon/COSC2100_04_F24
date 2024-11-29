namespace Demo_w12a_DatabaseCompletion
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportleaguesDataSetTeams = new Demo_w12a_DatabaseCompletion.SportleaguesDataSetTeams();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.playeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isactiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jerseynumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerRostersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sportleaguesDataSetPlayersOnTeamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportleaguesDataSetPlayersOnTeams = new Demo_w12a_DatabaseCompletion.SportleaguesDataSetPlayersOnTeams();
            this.playerRostersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter = new Demo_w12a_DatabaseCompletion.SportleaguesDataSetTeamsTableAdapters.teamsTableAdapter();
            this.playerRostersTableAdapter = new Demo_w12a_DatabaseCompletion.SportleaguesDataSetPlayersOnTeamsTableAdapters.PlayerRostersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSetTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRostersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSetPlayersOnTeamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSetPlayersOnTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRostersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.teamsBindingSource;
            this.comboBox1.DisplayMember = "teamname";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "teamid";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "teams";
            this.teamsBindingSource.DataSource = this.sportleaguesDataSetTeams;
            // 
            // sportleaguesDataSetTeams
            // 
            this.sportleaguesDataSetTeams.DataSetName = "SportleaguesDataSetTeams";
            this.sportleaguesDataSetTeams.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playeridDataGridViewTextBoxColumn,
            this.regnumberDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.isactiveDataGridViewTextBoxColumn,
            this.jerseynumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.playerRostersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(935, 502);
            this.dataGridView1.TabIndex = 1;
            // 
            // playeridDataGridViewTextBoxColumn
            // 
            this.playeridDataGridViewTextBoxColumn.DataPropertyName = "playerid";
            this.playeridDataGridViewTextBoxColumn.HeaderText = "playerid";
            this.playeridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.playeridDataGridViewTextBoxColumn.Name = "playeridDataGridViewTextBoxColumn";
            this.playeridDataGridViewTextBoxColumn.Width = 150;
            // 
            // regnumberDataGridViewTextBoxColumn
            // 
            this.regnumberDataGridViewTextBoxColumn.DataPropertyName = "regnumber";
            this.regnumberDataGridViewTextBoxColumn.HeaderText = "regnumber";
            this.regnumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.regnumberDataGridViewTextBoxColumn.Name = "regnumberDataGridViewTextBoxColumn";
            this.regnumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // isactiveDataGridViewTextBoxColumn
            // 
            this.isactiveDataGridViewTextBoxColumn.DataPropertyName = "isactive";
            this.isactiveDataGridViewTextBoxColumn.HeaderText = "isactive";
            this.isactiveDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.isactiveDataGridViewTextBoxColumn.Name = "isactiveDataGridViewTextBoxColumn";
            this.isactiveDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isactiveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isactiveDataGridViewTextBoxColumn.Width = 150;
            // 
            // jerseynumberDataGridViewTextBoxColumn
            // 
            this.jerseynumberDataGridViewTextBoxColumn.DataPropertyName = "jerseynumber";
            this.jerseynumberDataGridViewTextBoxColumn.HeaderText = "jerseynumber";
            this.jerseynumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jerseynumberDataGridViewTextBoxColumn.Name = "jerseynumberDataGridViewTextBoxColumn";
            this.jerseynumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // playerRostersBindingSource1
            // 
            this.playerRostersBindingSource1.DataMember = "PlayerRosters";
            this.playerRostersBindingSource1.DataSource = this.sportleaguesDataSetPlayersOnTeamsBindingSource;
            // 
            // sportleaguesDataSetPlayersOnTeamsBindingSource
            // 
            this.sportleaguesDataSetPlayersOnTeamsBindingSource.DataSource = this.sportleaguesDataSetPlayersOnTeams;
            this.sportleaguesDataSetPlayersOnTeamsBindingSource.Position = 0;
            // 
            // sportleaguesDataSetPlayersOnTeams
            // 
            this.sportleaguesDataSetPlayersOnTeams.DataSetName = "SportleaguesDataSetPlayersOnTeams";
            this.sportleaguesDataSetPlayersOnTeams.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerRostersBindingSource
            // 
            this.playerRostersBindingSource.DataMember = "PlayerRosters";
            this.playerRostersBindingSource.DataSource = this.sportleaguesDataSetPlayersOnTeamsBindingSource;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // playerRostersTableAdapter
            // 
            this.playerRostersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 673);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSetTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRostersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSetPlayersOnTeamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSetPlayersOnTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRostersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SportleaguesDataSetTeams sportleaguesDataSetTeams;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private SportleaguesDataSetTeamsTableAdapters.teamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.BindingSource sportleaguesDataSetPlayersOnTeamsBindingSource;
        private SportleaguesDataSetPlayersOnTeams sportleaguesDataSetPlayersOnTeams;
        private System.Windows.Forms.BindingSource playerRostersBindingSource;
        private SportleaguesDataSetPlayersOnTeamsTableAdapters.PlayerRostersTableAdapter playerRostersTableAdapter;
        private System.Windows.Forms.BindingSource playerRostersBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn playeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isactiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jerseynumberDataGridViewTextBoxColumn;
    }
}

