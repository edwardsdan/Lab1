using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class MathMethods
    {
        public static void CalcArea(double x, double y)
        {
            double Area = x * y;
            Console.WriteLine($"The area is {Area} square feet");
        }

        public static void CalcPerim(double x, double y)
        {
            double Perimeter = x * 2 + y * 2;
            Console.WriteLine($"The perimeter is {Perimeter} feet");
        }

        public static void CalcVolume(double x, double y, double z)
        {
            double Volume = x * y * z;
            Console.WriteLine($"The volume is {Volume} cubic feet");
        }
    }
}
