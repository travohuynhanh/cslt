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
            for (int y = -5; y <= 5; y++)
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
            double total = hours + minutes / 60.0 + seconds / 3600.0;
            double speedkmh = distance / total;
            double miles = distance / 1609.9;
            double speedmilesh = miles / total;
            Console.WriteLine($"speed in kilometers per hour: {speedkmh} (km / h)");
            Console.WriteLine($"speed in miles per hour: {speedmilesh} (miles/ h)");

        }
        static void bai04()
        {
            Console.Write("Input radius: ");
            if (double.TryParse(Console.ReadLine(), out double radius) && radius >= 0)
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
            char c = char.Parse(Console.ReadLine());
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
            Console.Write("nhập hệ số a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("nhập hệ số b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("nhập hệ số c: ");
            double c = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phương trình vô số nghiệm");
                    else
                        Console.WriteLine("Phương trình vô nghiệm");
                }
                else
                    Console.WriteLine($"Phương trình có nghiệm x = - c / b = {-c / b} ");
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Phương trình có nghiệm kép x1 = x2 = - b / (2 * a)= {x}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Phương trình có 2 nghiệm phân biệt:x1 = {x1} và x2 = {x2}");
                }
            }


        }
        static void Bai1()
        {
            Console.Write("Nhập số bất kì:  ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine($"{num} là số chẵn");
            else
                Console.WriteLine($"{num} là số lẻ");
        }
        static void Bai2()
        {
            Console.Write("nhập số đầu: ");
            int so1 = int.Parse(Console.ReadLine());
            Console.Write("nhập số thứ 2: ");
            int so2 = int.Parse(Console.ReadLine());
            Console.Write("nhập số thứ 3: ");
            int so3 = int.Parse(Console.ReadLine());
            int max = so1;
            if (max < so2) max = so2;
            if (max < so3) max = so3;
            Console.WriteLine($"số lớn nhất là {max}");
        }
        static void Bai3()
        {
            Console.Write("Nhập cạnh 1: ");
            double c1 = double.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh 2: ");
            double c2 = double.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh 3: ");
            double c3 = double.Parse(Console.ReadLine());
            if (c1 + c2 > c3 && c1 + c3 > c2 && c2 + c3 > c1)
            {
                if (c1 == c2 && c2 == c3)
                { Console.WriteLine("Đây là tam giác đều"); }
                else if (c1 == c2 || c1 == c3 || c2 == c3)
                { Console.WriteLine("Đây là tam giác cân"); }
                else { Console.WriteLine("Đây là tam giác thường"); }
            }
            else { Console.WriteLine("Ba cạnh này không tạo thành 1 tam giác"); }
        }
        static void Bai4()
        {
            Console.Write("Nhập toạ độ x: ");
            double toadox = double.Parse(Console.ReadLine());
            Console.Write("Nhập toạ độ y: ");
            double toadoy = double.Parse(Console.ReadLine());
            if (toadox > 0 && toadoy > 0)
            { Console.WriteLine($"Toạ độ ({toadox},{toadoy}) thuộc góc phần tư thứ I"); }
            else if (toadox < 0 && toadoy > 0)
            { Console.WriteLine($"Toạ độ ({toadox},{toadoy}) thuộc góc phần tư thứ II"); }
            else if (toadox < 0 && toadoy < 0)
            { Console.WriteLine($"Toạ độ ({toadox},{toadoy}) thuộc góc phần tư thứ III"); }
            else if (toadox > 0 && toadoy < 0)
            { Console.WriteLine($"Toạ độ ({toadox},{toadoy}) thuộc góc phần tư thứ IV"); }
            else if (toadox == 0 && toadoy == 0)
            { Console.WriteLine($"Toạ độ ({toadox},{toadoy}) thuộc gốc toạ độ O"); }
            else if (toadox == 0)
            { Console.WriteLine($"Toạ độ ({toadox},{toadoy}) nằm trên trục tung Oy"); }
            else
            { Console.WriteLine($"Toạ độ ({toadox},{toadoy}) nằm trên trục hoành Ox"); }
        }
        public static void Main4(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bai01();
            bai02();
            bai03();
            bai04();
            bai05();
            giaipt();
            Bai1();
            Bai2();
            Bai3();
            Bai4();
        }
    }
}





