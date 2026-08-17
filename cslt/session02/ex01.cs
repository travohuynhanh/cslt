using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session02
{
    internal class ex01
    {
        public static void Main(String[] args)
        {
            // 1. To Add/ Sum two numbers
            Console.WriteLine("To Add / Sum two numbers");
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The answer is: {num1 + num2}\n");

            // 2. to Swap Values of Two Variables.
            Console.WriteLine("to Swap Values of Two Variables.");
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"After swapping:a={a} b={b}\n");
            // 3. to Multiply two Floating Point Numbers
            Console.WriteLine("to Multiply two Floating Point Numbers");
            Console.Write("Enter first float number: ");
            float f1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter second float number: ");
            float f2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"The answer is: {f1 * f2}\n");
            //4. to convert feet to meter
            Console.WriteLine(" to convert feet to meter");
            Console.Write("Enter distance in feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            double meter = feet * 0.3048;
            Console.WriteLine($"{feet} feet = {meter} meter\n");
            // 5.to convert Celsius to Fahrenheit and vice versa
            Console.Write("Enter temperature in celcius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C = {fahrenheit} F ");
            //6. to find the Size of data types
            Console.WriteLine($"Size of double data type is {sizeof(double)}");
            Console.WriteLine($"Size of int data type is {sizeof(int)}");
            //7. to Print ASCII Value (tip: read character, print number of this char)
            Console.Write("Enter a character: ");
            int ch = Console.Read();
            Console.WriteLine($"ASCII code of {(char)c} is {ch}");
            //8. to Calculate Area of Circle
            double r = 5.2;
            double ac = r * r * Math.PI;
            Console.WriteLine($"Area of circle: {ac} ");
            //9. to Calculate Area of Square
            double d = 4.2;
            double cs = d * d;
            Console.WriteLine($"Area of square: {cs} ");
            //10. to convert days to years, weeks and days
            int days = 2764;
            int years = days / 365;
            int weeks = (days - years * 365) / 7;
            int dayleft = days - years * 365 - weeks * 7;
            Console.WriteLine($"days: {days}");
            Console.WriteLine($"{days} days = {years} years, {weeks} weeks, {dayleft} days");

        }
    }
}
