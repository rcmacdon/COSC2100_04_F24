using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_w11a_MoreBindingandEnheritance.Classes
{
    public class Car : Vehicle
    {

        List<Car> cars = new List<Car>();

        public string BodyType { get; set; }
        public int NumDoors { get; set; }

        public Car() { }
        private Car(string bodyType, int numDoors)
        {
            BodyType = bodyType;
            NumDoors = numDoors;
        }

        public Car(string vin, string make, string model, int manufactureYear, Color colour, string bodyType, int numDoors) : base(vin, make, model, manufactureYear, colour) 
        {
            BodyType = bodyType;
            NumDoors = numDoors;
        }

        public override string ToString()
        {
            return base.ToString() + ' ' + BodyType;
        }
    }
}
