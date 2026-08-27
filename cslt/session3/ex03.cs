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

        static void Bai01()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhap chi so dien cu (kWh): ");
            decimal csd_cu = decimal.Parse(Console.ReadLine());

            Console.Write("Nhap chi so dien moi (kWh): ");
            decimal csd_moi = decimal.Parse(Console.ReadLine());

            // 1. Kiểm tra điều kiện chỉ số
            if (csd_moi < csd_cu)
            {
                Console.WriteLine("Loi: Chi so moi phai lon hon hoac bang chi so cu!");
                return;
            }

            decimal so_dien = csd_moi - csd_cu;
            decimal tiendien = 0;

            // 2. Tính tiền điện theo bậc thang (Đơn giá: 1806, 1866, 2167, 2729, 3050)
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

            decimal thueVAT = tiendien * 0.08m;
            decimal tongThanhToan = tiendien + thueVAT;

            // 3. In kết quả chuẩn định dạng phân cách hàng nghìn
            CultureInfo cul = new CultureInfo("vi-VN");
            Console.WriteLine($"\nSo dien tieu thu: {so_dien} kWh");
            Console.WriteLine($"Tien dien chua thue: {tiendien:N0} VNĐ");
            Console.WriteLine($"Thue VAT (8%): {thueVAT} VNĐ");
            Console.WriteLine($"Tong thanh toan: {tongThanhToan} VNĐ");
        }

        static void Bai02()
        {
            Console.Write("\n\nNhap chieu cao (met): ");
            double chieucao = double.Parse(Console.ReadLine());
            Console.Write("Nhap can nang (kg): ");
            double cannang = double.Parse(Console.ReadLine());

            // Tính chỉ số BMI
            double bmi = cannang / (chieucao * chieucao);

            // Xác định cấp độ béo phì
            string capdo;
            if (bmi < 18.5)
                capdo = "Gầy";
            else if (bmi < 23)
                capdo = "Bình thường";
            else if (bmi < 25)
                capdo = "Thừa cân";
            else
                capdo = "Béo phì";

            // In kết quả
            Console.WriteLine($"Chi so BMI: {bmi:F2}");
            Console.WriteLine($"Phan loai suc khoe: {capdo}");
        }

        static void Bai04()
        {
            Console.Write("\n\nNhap ngay sinh (dd/mm/yyyy): ");
            string Date = Console.ReadLine();

            //1. Chuyển đổi chuỗi ngày sinh thành đối tượng DateTime
            if (!DateTime.TryParseExact(Date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate))
            {
                Console.WriteLine("Loi: Ngay sinh khong hop le!");
                return;
            }

            // 2. Lấy ngày hiện tại hệ thống
            DateTime today = DateTime.Now.Date;

            if (birthDate > today)
            {
                Console.WriteLine("Loi: Ngay sinh khong duoc lon hon ngay hien tai!");
                return;
            }

            // 3. Tính tuổi
            int age = today.Year - birthDate.Year;

            if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day))
            {
                age--;
            }

            // 4. Tính tổng số ngày đã sống từ lúc sinh ra
            TimeSpan timelived = today - birthDate;
            int totalDaysLived = (int)timelived.TotalDays;

            // 5. Xác định ngày sinh tiếp theo
            DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);
            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            //6. Tính số ngày còn lại đến ngày sinh tiếp theo
            TimeSpan timeUntilNextBirthday = nextBirthday - today;
            int daysUntilNextBirthday = (int)timeUntilNextBirthday.TotalDays;

            // 7. In kết quả
            Console.WriteLine($"Tuoi hien tai: {age} tuoi");
            Console.WriteLine($"Ban da song tong cong: {totalDaysLived} ngay");
            Console.WriteLine($"Ngay sinh tiep theo: {nextBirthday:dd/MM/yyyy}");
            Console.WriteLine($"Con {daysUntilNextBirthday} ngay nua la sinh nhat");

        }

        static void Bai05()
        {
            // 1. Nhập điểm số các môn học
            Console.Write("\n\nNhap diem so C# (4 TC) (Thang diem 0-10): ");
            double diemCSharp = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem so Toan roi rac (3 TC) (Thang diem 0-10): ");
            double diemtoan = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem so Tieng Anh (2 TC) (Thang diem 0-10): ");
            double diemTiengAnh = double.Parse(Console.ReadLine());

            // 2. Tính điểm trung bình thang 10
            double diemtb = (diemCSharp * 4 + diemtoan * 3 + diemTiengAnh * 2) / (4 + 3 + 2);

            // 3. Chuyển đổi điểm trung bình sang thang 4
            string diem = "";
            string gpa = "";
            string xepLoai = "";

            if (diemtb < 4)
            {
                diem = "0";
                gpa = "F";
                xepLoai = "Kém (Trượt)";

            }
            else if (diemtb < 5.5)
            {
                diem = "1";
                gpa = "D";
                xepLoai = "Yếu";
            }
            else if (diemtb < 7)
            {
                diem = "2";
                gpa = "C";
                xepLoai = "Trung bình";
            }
            else if (diemtb < 8.5)
            {
                diem = "3";
                gpa = "B";
                xepLoai = "Khá";
            }
            else
            {
                diem = "4";
                gpa = "A";
                xepLoai = "Giỏi";
            }


            // 4. In kết quả
            Console.WriteLine($"Diem trung binh thang 10: {diemtb:F2}");
            Console.WriteLine($"Diem chu quy doi: {diem}");
            Console.WriteLine($"Diem GPA thang 4: {gpa}");
            Console.WriteLine($"Xep loai hoc luc: {xepLoai}");
        }

        static void Bai11()
        {
            //1 . Nhập số tiền gửi, lãi suất và thời gian gửi
            Console.Write("So tien gui: ");
            decimal P = decimal.Parse(Console.ReadLine());
            Console.Write("Lai suat (hang nam): ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Thoi gian gui (thang): ");
            int n = int.Parse(Console.ReadLine());

            //2 . Tính số tiền lãi và tổng số tiền nhận được

            //Tính lãi đơn
            decimal tienlaidon = P * (decimal)(r / 100) * n / 12;
            //Tính lãi kép
            double tienlaikep = (double)P * Math.Pow(1 + (r / 100) / 12, n) - (double)P;
            decimal tongtienlaikep = (decimal)tienlaikep;

            decimal chenhlech = tongtienlaikep - tienlaidon;

            //3 . In kết quả
            Console.WriteLine($"Tien lai don: {tienlaidon:N0} VNĐ");
            Console.WriteLine($"Tien lai kep: {tongtienlaikep:N0} VNĐ");
            Console.WriteLine($"Loi nhuan chenh lech: {chenhlech:N0} VNĐ");
        }
        static void Bai07()
        {
            // 1. Nhập thông tin về quãng đường, mức tiêu hao nhiên liệu, giá xăng và số người đi cùng
            Console.Write("\n\n Quang duong (km): ");
            double s = double.Parse(Console.ReadLine());
            Console.Write("Muc tieu hao (Lit/100km): ");
            double l = double.Parse(Console.ReadLine());
            Console.Write("Gia xang (VND/Lit): ");
            decimal giaXang = decimal.Parse(Console.ReadLine());
            Console.Write("So nguoi di cung: ");
            int soNguoi = int.Parse(Console.ReadLine());

            //2 . Tính tổng chi phí xăng và chi phí cho mỗi người
            double xangTieuThu = (s * l) / 100;
            decimal tongTienXang = (decimal)xangTieuThu * giaXang;
            decimal chiPhiMoiNguoi = Math.Ceiling((tongTienXang / soNguoi) / 1000m) * 1000m;

            // 3. In kết quả
            Console.WriteLine($"Tong nhien lieu tieu thu: {xangTieuThu:F2} Lit");
            Console.WriteLine($"Tong chi phi xang: {tongTienXang:N0} VNĐ");
            Console.WriteLine($"Chi phi moi nguoi: {chiPhiMoiNguoi:N0} VNĐ");

        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai01slide();
            Bai02slide();
            Bai03slide();
            Bai01();
            Bai02();
            Bai04();
            Bai05();
            Bai07();
            Bai11();

        }

    }
}
