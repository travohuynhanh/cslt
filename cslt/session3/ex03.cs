using System;
using System.Collections.Generic;
using System.Globalization;
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
                double surface = 4 * Math.PI * Math.Pow(radius, 2);
                double volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);

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
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} x {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a}mod{b}={a % b}");
        }

        static void Bai01()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Chi so dien cu (kWh): ");
            decimal csd_cu = decimal.Parse(Console.ReadLine());

            Console.Write("Chi so dien moi (kWh): ");
            decimal csd_moi = decimal.Parse(Console.ReadLine());
            if (csd_moi < csd_cu)
            {
                Console.WriteLine("Chi so moi phai lon hon hoac bang chi so cu!");
                return;
            }

            decimal so_dien = csd_moi - csd_cu;
            decimal tiendien = 0;

            if (so_dien <= 50)
            {
                tiendien = so_dien * 1806m;
            }
            else if (so_dien <= 100)
            {
                tiendien = 50 * 1806m + (so_dien - 50) * 1866m;
            }
            else if (so_dien <= 200)
            {
                tiendien = 50 * 1806m + 50 * 1866m + (so_dien - 100) * 2167m;
            }
            else if (so_dien <= 300)
            {
                tiendien = 50 * 1806m + 50 * 1866m + 100 * 2167m + (so_dien - 200) * 2729m;
            }
            else
            {
                tiendien = 50 * 1806m + 50 * 1866m + 100 * 2167m + 100 * 2729m + (so_dien - 300) * 3050m;
            }

            decimal VAT = tiendien * 0.08m;
            decimal ThanhToan = tiendien + VAT;

            CultureInfo cul = new CultureInfo("vi-VN");
            Console.WriteLine($"\nSo dien tieu thu: {so_dien} kWh");
            Console.WriteLine($"Tien dien chua thue: {tiendien:N0} VNĐ");
            Console.WriteLine($"Thue VAT (8%): {VAT} VNĐ");
            Console.WriteLine($"Tong thanh toan: {ThanhToan} VNĐ");
        }

        static void Bai02()
        {
            Console.Write("Chiều cao (met): ");
            double chieucao = double.Parse(Console.ReadLine());
            Console.Write("Cân nặng (kg): ");
            double cannang = double.Parse(Console.ReadLine());

            double BMI = cannang / (chieucao * chieucao);

            string capdo;
            if (BMI < 18.5)
                capdo = "Gầy";
            else if (BMI < 23)
                capdo = "Bình thường";
            else if (BMI < 25)
                capdo = "Thừa cân";
            else
                capdo = "Béo phì";

            Console.WriteLine($"Chỉ số BMI: {BMI:F2}");
            Console.WriteLine($"Phân loại sức khỏe: {capdo}");
        }

        static void Bai03()
        {
            Console.Write("Nhập số tiền VNĐ: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal soTienVND) || soTienVND <= 0)
            {
                Console.WriteLine("Lỗi: Số tiền VNĐ không hợp lệ!");
                return;
            }

            Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            if (!int.TryParse(Console.ReadLine(), out int chon))
            {
                Console.WriteLine("Lỗi: Lựa chọn không hợp lệ!");
                return;
            }

            decimal tyGia = 0m;
            string tenNgoaiTe = "";

            if (chon == 1)
            {
                tenNgoaiTe = "USD";
                tyGia = 25400m;
            }
            else if (chon == 2)
            {
                tenNgoaiTe = "EUR";
                tyGia = 27200m;
            }
            else if (chon == 3)
            {
                tenNgoaiTe = "JPY";
                tyGia = 165m;
            }
            else if (chon == 4)
            {
                tenNgoaiTe = "GBP";
                tyGia = 32100m;
            }
            else
            {
                Console.WriteLine("Ngoại tệ chọn không nằm trong danh sách (1-4)!");
                return;
            }

            decimal phiDichVu = soTienVND * 0.005m;
            decimal soTienThucTe = soTienVND - phiDichVu;
            decimal soTienNgoaiTe = soTienThucTe / tyGia;
            Console.WriteLine($"Phí dịch vụ (0.5%): {phiDichVu:N0} VNĐ");
            Console.WriteLine($"Số tiền VNĐ tính đổi: {soTienThucTe:N0} VNĐ");
            Console.WriteLine($"Số tiền {tenNgoaiTe} nhận được: {soTienNgoaiTe:F2} {tenNgoaiTe}");

        }


        static void Bai04()
        {
            Console.Write("Nhập ngày sinh (dd/mm/yyyy): ");
            string Date = Console.ReadLine();

            if (!DateTime.TryParseExact(Date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate))
            {
                Console.WriteLine("Ngày sinh không hợp lệ!");
                return;
            }

            DateTime today = DateTime.Now.Date;

            if (birthDate > today)
            {
                Console.WriteLine("Ngày sinh không được lớn hơn ngày hiện tại!");
                return;
            }

            int age = today.Year - birthDate.Year;

            if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day))
            {
                age--;
            }

            TimeSpan timelived = today - birthDate;
            int totalDaysLived = (int)timelived.TotalDays;

            DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);
            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            TimeSpan timeUntilNextBirthday = nextBirthday - today;
            int daysUntilNextBirthday = (int)timeUntilNextBirthday.TotalDays;

            Console.WriteLine($"Tuổi hiện tại: {age} tuoi");
            Console.WriteLine($"Bạn đã sống tổng cộng: {totalDaysLived} ngay");
            Console.WriteLine($"Ngày sinh tiếp theo: {nextBirthday:dd/MM/yyyy}");
            Console.WriteLine($"Còn {daysUntilNextBirthday} ngay nữa là sinh nhật");

        }

        static void Bai05()
        {

            Console.Write("Nhập điểm số C# (4 TC) Thang 10: ");
            double CSharp = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm số Toán rời rạc (3 TC) Thang 10: ");
            double toan = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm số Tiếng Anh (2 TC) Thang 10: ");
            double TiengAnh = double.Parse(Console.ReadLine());

            double diemtb = (CSharp * 4 + toan * 3 + TiengAnh * 2) / (4 + 3 + 2);

            string diemchu = "";
            string gpa = "";
            string xepLoai = "";

            if (diemtb < 4)
            {
                diemchu = "0";
                gpa = "F";
                xepLoai = "Kém (Trượt)";

            }
            else if (diemtb < 5.5)
            {
                diemchu = "1";
                gpa = "D";
                xepLoai = "Yếu";
            }
            else if (diemtb < 7)
            {
                diemchu = "2";
                gpa = "C";
                xepLoai = "Trung bình";
            }
            else if (diemtb < 8.5)
            {
                diemchu = "3";
                gpa = "B";
                xepLoai = "Khá";
            }
            else
            {
                diemchu = "4";
                gpa = "A";
                xepLoai = "Giỏi";
            }


            Console.WriteLine($"Điểm trung bình thang 10: {diemtb:F2}");
            Console.WriteLine($"Điểm chữ quy đổi: {diemchu}");
            Console.WriteLine($"Điểm GPA thang 4: {gpa}");
            Console.WriteLine($"Xếp loại học lực: {xepLoai}");
        }

        public static void Main3(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai01slide();
            Bai02slide();
            Bai03slide();
            Bai01();
            Bai02();
            Bai03();
            Bai04();
            Bai05();


        }

    }
}


