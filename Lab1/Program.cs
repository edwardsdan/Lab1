using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter the length of the room");
                double length = Validation.CheckDimensionInput(Console.ReadLine());
                Console.WriteLine("Please enter the width of the room");
                double width = Validation.CheckDimensionInput(Console.ReadLine());
                Console.WriteLine("Please enter the height of the room");
                double height = Validation.CheckDimensionInput(Console.ReadLine());

                MathMethods.CalcArea(length, width);
                MathMethods.CalcPerim(length, width);
                MathMethods.CalcVolume(length, width, height);

                if (Validation.Continue() == false)
                    break;
            }

            Console.WriteLine("Thank you for using the GC Room Detail Generator!");
        }
    }
}
