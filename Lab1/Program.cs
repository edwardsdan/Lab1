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
            // continuing with recursive call
            Console.WriteLine("Please enter the length of the room");
            double Length = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the width of the room");
            double Width = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the height of the room");
            double Height = double.Parse(Console.ReadLine());

            double Area = Width * Length;
            double Perimeter = 2 * Width + 2 * Length;
            double Volume = Width * Length * Height;

            Console.WriteLine($"The area of the room is {Area} square feet");
            Console.WriteLine($"The perimeter of the room is {Perimeter} feet");
            Console.WriteLine($"The volume of the room is {Volume} cubic feet");

            Console.WriteLine("Would you like to measure another room? (y/n)");
            string Continue = Console.ReadLine();
            if (Continue == "y" || Continue == "Y")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Thank you for using the GC Room Detail Generator!");
            }
            // continuing with while loop
            /*int i = 0;
            while(i < 1)
            {
                Console.WriteLine("Please enter the length of the room");
                double Length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width of the room");
                double Width = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height of the room");
                double Height = double.Parse(Console.ReadLine());

                double Area = Width * Length;
                double Perimeter = 2 * Width + 2 * Length;
                double Volume = Width * Length * Height;

                Console.WriteLine($"The area of the room is {Area} square feet");
                Console.WriteLine($"The perimeter of the room is {Perimeter} feet");
                Console.WriteLine($"The volume of the room is {Volume} cubic feet");

                Console.WriteLine("Would you like to measure another room? (y/n)");
                string Continue = Console.ReadLine();
                if (Continue == "n" || Continue == "N")
                {
                    Console.WriteLine("Thank you for using the GC Room Detail Generator!");
                    i = 1;
                }*/
        }
    }
}
