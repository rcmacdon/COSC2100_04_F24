using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_w05a_Collections
{
    public partial class frmCollections : Form
    {

        private String[] colors = { "Red", "Blue", "Green" };
        private String[] colors2 = new string[3];

        private String[] players = new string[5]; // for 4 players leaving 0 unused

        private int[,] scores = new int[5, 19]; // 4 players and 18 holes (Golf)

        // predefining values in a 2D array
        // { {,,,,}, {,,,,,}, {,,,,,} }

        private List<String> students = new List<String>();
        private List<String> groupOne = new List<String>();


        public frmCollections()
        {
            InitializeComponent();
        }

        private void frmCollections_Load(object sender, EventArgs e)
        {
            initialize();
        }

        private void initialize()
        {
            // populate the color2 array
            colors2[0] = "Violet";
            colors2[1] = "Crimson";
            colors2[2] = "Aqua";
            //colors2[3] = "Lime";

            //players
            for (int p = 0; p <= 4; p++)
            {
                //holes
                for (int h = 0; h <= 18; h++)
                {
                    scores[p, h] = 0;
                }
            }


            // list of students
            students.Add("Clint");
            students.Add("John");
            students.Add("Sally");
            students.Add("Raj");
            students.Add("William");
            students.Add("Mike");
            students.Add("Roman");
            students.Add("Harmondeep");
            students.Add("George");
            students.Add("Wai");
            
            students.Sort();

            listBox1.DataSource = students;

            //MessageBox.Show(students[5]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add students to groupOne
            if (listBox1.SelectedItems.Count > 0)
            {

                String str = listBox1.SelectedItem.ToString();
                int pos = students.IndexOf(str);

                MessageBox.Show("The person " + str + " is at position " + pos.ToString());

                groupOne.Add(str);
                students.Remove(str);

                RedrawListBoxes();
            }
        }

        private void RedrawListBoxes()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;

            listBox1.DataSource = students;
            listBox2.DataSource = groupOne;

            label1.Text = students.Count.ToString();
            label2.Text = groupOne.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // remove student from groupOne
            if (listBox2.SelectedItems.Count > 0) 
            { 
                students.Add(listBox2.SelectedItem.ToString());
                groupOne.Remove(listBox2.SelectedItem.ToString());
                RedrawListBoxes();
            }
        }
    }
}
