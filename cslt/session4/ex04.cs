using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session4
{
    internal class ex04
    {
        static void bai01()
        {
            Console.Write("Input a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} x {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a}mod{b}={a % b}");
        }
        static void bai02()
        {
            Console.WriteLine(" x = y2 + 2y + 1");
            for(int y = -5; y<= 5;y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"y = {y}, x ={x}");
            }
        }
        static void bai03()
        {
            Console.Write("Input distance(km): ");
            double distance = double.Parse(Console.ReadLine());
            Console.Write("Input hours: ");
            double hours = double.Parse(Console.ReadLine());
            Console.Write("Input minutes: ");
            double minutes = double.Parse(Console.ReadLine()); 
            Console.Write("Input seconds: ");
            double seconds = double.Parse(Console.ReadLine());
            double total = hours + minutes/60.0 + seconds/3600.0;
            double speedkmh = distance / total;
            double miles = distance / 1609.9;
            double speedmilesh = miles / total;
            Console.WriteLine($"speed in kilometers per hour: {speedkmh} (km / h)");
            Console.WriteLine($"speed in miles per hour: {speedmilesh} (miles/ h)");
          
        }
        static void bai04()
        {
            Console.Write("Input radius: ");
            if (double.TryParse(Console.ReadLine(), out double radius) && radius >=0)
            {
                double surface = 4 * Math.PI * Math.Pow(radius, 2);
                double volume = 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);

                Console.WriteLine($"surface = {surface:F2}");
                Console.WriteLine($"volume = {volume:F2}");
            }
            else
            { Console.WriteLine("incorrect, please try again "); }
        }
        static void bai05()
        {
            Console.Write("enter a character: ");
            char c =char.Parse(Console.ReadLine());
            if ("aiueoAIUEO".Contains(c))
                {
                Console.WriteLine("Vowel");
            }
            else if (char.IsDigit(c))
            {
                Console.WriteLine("Digit");
            }
            else { Console.WriteLine("other symbol"); }

        }
        static void giaipt()
        {
            Console.Write("nhập hệ số a: "); int a = int.Parse(Console.ReadLine());
            Console.Write("nhập hệ số b: "); int b = int.Parse(Console.ReadLine());
            Console.Write("nhập hệ số c: "); int c = int.Parse(Console.ReadLine());
            if (a==0)
            { if (b==0)
                { if (c==0)
                    { Console.WriteLine("vô số nghiệm"); }    }    
        }
    }
}
