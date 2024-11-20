using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Demo_w11a_MoreBindingandEnheritance.Classes
{


    /* - Public     - accessible from anywhere in the project
     * - Private    - accessible from within the current class
     * - Protected  - accessible fron within the current class and inherited classes
     * - Internal   - accessible by the same namespace 
     * */
    public abstract class Vehicle
    {
        #region Properties
        public string Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int ManufactureYear { get; set; }
        public Color Colour { get; set; }
        #endregion


        #region Constructors
        public Vehicle() { }

        public Vehicle(string vin, string make, string model, int manufactureYear, Color colour)
        {
        Vin = vin;
        Make = make;
        Model = model;
        ManufactureYear = manufactureYear;
        Colour = colour;
        }
        #endregion

        public override string ToString()
        {
            return ManufactureYear.ToString() + ' ' + Make + ' ' + Model;
        }
    }
    }
