using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c09_cember_ve_daire
{
    public class Daire
    {
        public const double pi = 3.14;
        public static double alan(double r)
        {
            return pi * r * r; 
        }
        public static double alan(double r, double alfa)
        {
            return pi * r * r * (alfa / 360);
        }
    }
}
