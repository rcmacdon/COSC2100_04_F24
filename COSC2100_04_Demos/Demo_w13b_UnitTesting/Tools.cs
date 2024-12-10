using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_w13b_UnitTesting
{
    public static class Tools
    {

        public static decimal ConvertFtoC(decimal fahrenheit)
        {
            return Math.Round((fahrenheit - 32) * 5 / 9 , 2);
        }

        public static decimal ConvertCtoF(decimal celsius)
        {
            return celsius * 9 / 5 + 32;
        }


    }
}
