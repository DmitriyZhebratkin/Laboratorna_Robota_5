using System;
using System.Drawing;

namespace Lab_5_2
{
    class Program
    
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту конуса (H): ");
            Konus.h1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус конуса (R): ");
            Konus.r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту усеченного конуса (h): ");
            Konus.h2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите малый радиус усеченного уконуса (r): ");
            Konus.r2 = Convert.ToDouble(Console.ReadLine());

            Konus.Square(Konus.r1);
            Konus.Volume(Konus.r1, Konus.h2);
            Frustum.Volume_frustum(Frustum.r1, Frustum.r2, Frustum.h1);
        }
    }
}
