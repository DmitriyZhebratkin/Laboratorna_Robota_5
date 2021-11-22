using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_2
{
    class Konus
    {
        public static double r1;
        public static double h1;
        public static double r2;
        public static double h2;

        public static void Square(double r1)
        {
            double S = Math.PI * r1 * r1;
            Console.WriteLine("Площадь основания конуса равна : " + S);
        }
        public static void Volume(double r1, double h2)
        {
            double V = (Math.PI * r1 * r1) * h2 / 3;
            Console.WriteLine("Обьем конуса :" + V);
        }
    }
}
