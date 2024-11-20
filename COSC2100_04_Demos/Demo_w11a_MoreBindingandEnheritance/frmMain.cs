using Demo_w11a_MoreBindingandEnheritance.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_w11a_MoreBindingandEnheritance
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeSampleDataSetJoined.countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.employeeSampleDataSetJoined.countries);
            // TODO: This line of code loads data into the 'employeeSampleDataSetJoined.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeeSampleDataSetJoined.employees);
            // TODO: This line of code loads data into the 'employeeSampleDataSetJoined.JoinedTable' table. You can move, or remove it, as needed.
            this.joinedTableTableAdapter.Fill(this.employeeSampleDataSetJoined.JoinedTable);

        }


        public void InheritanceTester()
        {

            Car car = new Car();

            Car car2 = new Car("vin1", "Honda", "Civic", 2024, Color.Black, "Sedan", 4);

            Truck truck = new Truck("vin2", "GMC", "F150", 2022, Color.Orange, 12000, 3, 20000);

            Vehicle vehicle = new Vehicle();




        }


    }
}
