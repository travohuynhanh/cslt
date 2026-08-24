using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session3
{
    internal class ex03
    {
        static void Bai01slide()
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
        static void Bai02slide()
        {
            Console.Write("Input radius: ");
            if (double.TryParse(Console.ReadLine(), out double radius))
            {
                double surface = 4*Math.PI * Math.Pow(radius,2);
                double volume = 4/3 * Math.PI * Math.Pow(radius, 3);

                Console.WriteLine($"surface = {surface}");
                Console.WriteLine($"volume = {volume}");
            }
            else
            { Console.WriteLine("incorrect, please try again "); }
        }
        static void Bai03slide()
        {
            Console.Write("Input a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a+b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} x {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a}mod{b}={a%b}");
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai01slide();
            Bai02slide();
            Bai03slide();

        }

    }
}
