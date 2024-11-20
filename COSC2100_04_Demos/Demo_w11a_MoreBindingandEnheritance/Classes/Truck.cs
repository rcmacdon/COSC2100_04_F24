using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_w11a_MoreBindingandEnheritance.Classes
{
    public class Truck : Vehicle
    {
        List<Truck> trucks = new List<Truck>();

        public int Gvw { get; set; }
        public int NumAxles { get; set; }
        public int TowingCapacity { get; set; }

        public Truck() { }

        public Truck (string vin, string make, string model, int manufactureYear, Color colour, int gvw, int numAxles, int towingCapacity) : base(vin, make, model, manufactureYear, colour)
        {
            Gvw = gvw;
            NumAxles = numAxles;
            TowingCapacity = towingCapacity;
        }


    }
}
