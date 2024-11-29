using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_w12a_DatabaseCompletion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportleaguesDataSetTeams.teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.sportleaguesDataSetTeams.teams);

            //this.playerRostersTableAdapter.Fill(sportleaguesDataSetPlayersOnTeams.PlayerRosters, 222);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                this.playerRostersTableAdapter.Fill(sportleaguesDataSetPlayersOnTeams.PlayerRosters, (int)comboBox1.SelectedValue);
            }
        }
    }
}
