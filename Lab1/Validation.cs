using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Validation
    {
        public static double CheckDimensionInput(string Input)
        {
            double result;
            while(true)
            {
                if (double.TryParse(Input, out result))
                    break;
                else
                {
                    Console.WriteLine("That wasn't a number! Try again!");
                    Input = Console.ReadLine();
                }
            }
            return result;
        }

        public static bool Continue()
        {
            Console.WriteLine("Would you like to measure another room? (y/n)");
            string Input = Console.ReadLine().ToLower();
            while (true)
            {
                if (Input == "y" || Input == "yes")
                    return true;
                else if (Input == "n" || Input == "no")
                    return false;
                else
                {
                    Console.WriteLine("Sorry I didn't understand that! Try again!");
                    Input = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
