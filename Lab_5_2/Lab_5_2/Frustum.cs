using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_2
{
    class Frustum : Konus
    {
        public static void Volume_frustum(double r1, double r2, double h1) 
        {
            double V_frustum = Math.PI * h1 * ((r1 * r1) + (r2 * r2) + (r1 * r2)) / 3;
        }
    }

}
