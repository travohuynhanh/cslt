using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session_6
{
    internal class ex06
    {
        static int TinhTong(int a, int b)
        {
            return a + b;
        }
        static bool KiemTraChan(int n)
        {
            return n%2==0;
        }
        static int TimMax(int a, int b, int c) 
        {
           return Math.Max(Math.Max(a, b), c);
        }
        static long TinhGiaiThua(int n)
        {
            long result = 1;
            for (int i = 1; i<=n;  i++)
            {
                result = result* i;
            }
            return result;
        }
        static string DaoNguocChuoi(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static bool KiemTraNguyenTo (int n)
        {
            if (n<2)
            {
                return false;
            }
            for (int i = 2; i<n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void InFibonacci(int n)
        {
         if (n <= 0) return;
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int temp = a + b;
                a = b;
                b = temp;
            }   
        }
        static int DemNguyenAm(string s)
        {
            int count = 0;
            string na = "aeiouAEIOU";
            foreach (char c in s)
            {
                if (na.Contains(c)) count++;
            }
            return count;
        }
        static double TinhLuyThua(double x, int y)
        {
            double result = 1;
            int absy = Math.Abs(y);
            for (int i = 0; i < absy; i++)
            { result *= x;}
            if (y < 0)
            {
                return 1.0 / result;
            }
            return result;
        }
        static double TinhTrungBinh(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            return (double)sum / arr.Length;
        }
        static bool KiemTraDoiXung(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (char.ToLower(s[left]) != char.ToLower(s[right])) return false;
                left++;
                right--;
            }
            return true;
        }
        static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }
        static int TimMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;
        }
        static int TongCacChuSo(int n)
        {
            n = Math.Abs(n);
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        static void SapXepMang(int[] arr)
        {
            Array.Sort(arr);
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static string XoaTrungLap(string s)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in s)
            {
                if (!result.ToString().Contains(c))
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }
        static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static string DecimalToBinary(int n)
        {
            if (n == 0) return "0";
            string binary = "";
            while (n > 0)
            {
                binary = (n % 2) + binary;
                n /= 2;
            }
            return binary;
        }
        static bool KiemTraNamNhuan(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }
        static int DemSoTu(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) return 0;
            string[] words = sentence.Trim().Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Tổng 2 + 5 = {TinhTong(2, 5)}");
            Console.WriteLine($"8 là số chẵn? {KiemTraChan(8)}");
            Console.WriteLine($"Max(5, 12, 9) = {TimMax(5, 12, 9)}");
            Console.WriteLine($"5! = {TinhGiaiThua(5)}");
            Console.WriteLine($"Đảo ngược 'Huynhanh' = {DaoNguocChuoi("Huynhanh")}");
            Console.WriteLine($"7 là số nguyên tố? {KiemTraNguyenTo(7)} | 10 là số nguyên tố? {KiemTraNguyenTo(10)}");
            Console.Write("In 5 số Fibonacci đầu tiên: ");
            InFibonacci(5);
            Console.WriteLine($"Số nguyên âm trong 'Huynh Anh' = {DemNguyenAm("Huynh Anh")}");
            Console.WriteLine($"2^3 = {TinhLuyThua(2, 3)}");
            Console.WriteLine($"Trung bình [4, 5, 6, 7] = {TinhTrungBinh(new int[] { 4, 5, 6, 7 })}");
            Console.WriteLine($"'radar'có đối xứng không? {KiemTraDoiXung("radar")} | 'konnichiwa' có đối xứng không? {KiemTraDoiXung("konnichiwa")}");
            Console.WriteLine($"25°C = {CelsiusToFahrenheit(25)}F");
            Console.WriteLine($"Giá trị nhỏ nhất trong [10, 5, 8, 2, 9] = {TimMin(new int[] { 10, 5, 8, 2, 9 })}");
            Console.WriteLine($"Tổng chữ số của 1234 = {TongCacChuSo(1234)}");
            Console.Write("Sắp xếp [3, 1, 4, 2] = ");
            SapXepMang(new int[] { 3, 1, 4, 2 });
            Console.WriteLine($"Xóa trùng 'huynhanh' = {XoaTrungLap("huynhanh")}");
            Console.WriteLine($"(12, 18) = {UCLN(12, 18)}");
            Console.WriteLine($"10 sang nhị phân = {DecimalToBinary(10)}");
            Console.WriteLine($"Năm 2024 có phải năm nhuận? {KiemTraNamNhuan(2024)} | Năm 2023 có phải năm nhuận? {KiemTraNamNhuan(2023)}");
            Console.WriteLine($"Số từ trong 'Nobita shizuka' = {DemSoTu("Nobita Shizuka")}");
            Console.ReadLine();
        }
    }
}
