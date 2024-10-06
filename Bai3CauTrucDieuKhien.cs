using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3CauTrucDieuKhien
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.OutputEncoding = Encoding.UTF8;// hiển thị tiếng việt lên màn hình console

            // nhập vào số nguyên, kiểm tra có chia hết cho 3 không
            //Console.Write("nhap so nguyen: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(n % 3 == 0 ? "{0} chia hết cho 3" : "{0} không chia hết cho 3", n);

            // Bài 2: nhập số nguyên dương in bảng cửu chương từ 1 đến n
            //Console.Write("nhap so nguyen: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //    for (int j = 1; j <= 10; j++)
            //        Console.WriteLine("{0} X {1} = {2}", i, j, i * j);

            // Bài 3: nhập n, tính tổng giai thừa n
            //Console.Write("nhap so nguyen: ");
            //int n = int.Parse(Console.ReadLine());
            //int tong = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    int giaiThuaI = 1;
            //    for (int j = 1; j <= i; j++)
            //        giaiThuaI *= j;
            //    tong += giaiThuaI;
            //}
            //Console.WriteLine("tong cac giai thua tu 1 den {0} la {1}", n, tong);

            // Bài 4: nhập số nguyên, kiểm tra số chính phương
            //Console.Write("nhap so nguyen: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(((int)Math.Sqrt(n) * (int)Math.Sqrt(n) == n) ? "{0} la so chinh phuong" : "{0} khong phai so chinh phuong", n);

            //Bài 5: nhập tháng, hiển thị số ngày trong tháng
            //Console.Write("nhap thang: ");
            //int thang = int.Parse(Console.ReadLine());
            //Console.WriteLine("thang {0} co {1} ngay", thang, DateTime.DaysInMonth(DateTime.Now.Year, thang));

            // Bài 6: nhập số nguyên, tính tổng các i^i
            //Console.Write("nhap so nguyen: ");
            //int n = int.Parse(Console.ReadLine());
            //double tong = 0;
            //for (int i = 0; i <= n; i++)
            //    tong += Math.Pow(i,i);
            //Console.WriteLine("tong i^i la {0}", tong);

            // Bài 7: nhập số nguyên n, tính tổng các số lẻ từ 1 đến n
            //Console.Write("nhap so nguyen: ");
            //int n = int.Parse(Console.ReadLine());
            //int tong = 0;
            //for (int i = 1; i <= n; i++)
            //    tong += i % 2 != 0 ? i : 0;
            //Console.WriteLine("tong cac so le nho hon {0} la {1}", n, tong);

            // Bài 8: nhập số nguyên dương n in ra các số nguyên tố nhỏ hơn n
            //Console.Write("nhap so nguyen: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("so nguyen to nho hon {0}: ", n);
            //for (int i = 1; i < n; i++)
            //    Console.Write(IsPrime(i) ? "\t{0}" : "", i);

            // Bài 9: nhập vào độ dài cạnh, vẽ tam giác bằng '*'
            //Console.Write("nhap so nguyen: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //        Console.Write(i >= j ? " *" : "");
            //    Console.WriteLine(""); 
            //}

            // Bài 10: hiển thị dãy fibonacci
            //Console.Write("nhap so nguyen: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("day fibonacci: ");
            //int k1 = 1, k2 = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write("\t{0}", k1);
            //    int k3 = k2 + k1;
            //    k1 = k2;
            //    k2 = k3;
            //}    
               
            Console.ReadKey();
        }
        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
