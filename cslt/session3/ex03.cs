using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session3
{
    internal class ex03
    {
        static void Main(string[] args)
        {
            Console.Write("Input celsius: ");

            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
                double kelvin = celsius + 273;
                double fahrenheit = (celsius * 18 / 10) + 32;

                Console.WriteLine($"kelvin = {kelvin}");
                Console.WriteLine($"fahrenheit = {fahrenheit}");
            }
            else
            { Console.WriteLine("incorrect, please try again "); }
        }
    }
}
