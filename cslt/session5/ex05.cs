using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session5
{
    internal class ex05
    {
        static void Bai1lms()
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
        static void Bai2lms()
        {
            double sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Nhap so thu {i}: ");
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Tong = {sum}");
            Console.WriteLine($"trung binh cong = {sum / 10}");
        }
        static void Bai3lms()
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($" {i} x {j} = {i * j}");
                }
            }
        }
        static void Bai7lms()
        {
            Console.WriteLine("Nhap so can kiem tra: ");
            int so = int.Parse(Console.ReadLine());
            int tong = 0;
            for (int i = 1; i <= so / 2; i++)
            {
                if (so % i == 0)
                    tong += i;
            }
            if (tong == so)
            {
                Console.WriteLine($"So {so} la so hoan hao");
            }
            else
            { Console.WriteLine($"So {so} khong la so hoan hao"); }
        }
        static void Bai8lms()
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (n < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{n} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to.");
            }
        }
        static void Bai4lms()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        static void Bai5lms()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
            static void Main5( String[] args )
        {
            Bai1lms();
            Bai2lms();
            Bai3lms();
            Bai4lms();
            Bai5lms();
            Bai7lms();
            Bai8lms();
        }

    }
}
