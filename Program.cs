using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BaiLamBai2HangVaBienTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;// hiển thị tiếng việt lên màn hình console
            // Bài 1: nhập 2 số nguyên, tính tổng hiệu tích thương
            //int a, b;
            //Console.Write("nhap so thu nhat: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("nhap so thu hai: ");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            //Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            //Console.WriteLine("{0} X {1} = {2}", a, b, a * b);
            //Console.WriteLine("{0} / {1} = {2}", a, b, (float) a / b);

            // Bài 2: nhập hai cạnh, tính diện tích, chu vi HCN
            //float canh1, canh2;
            //Console.Write("nhap canh 1: ");
            //canh1 = float.Parse(Console.ReadLine());
            //Console.Write("nhap canh 2: ");
            //canh2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("chu vi: {0}", 2 * (canh1 + canh2));
            //Console.WriteLine("dien tich: {0}", canh1 * canh2);

            // Bài 3: nhập đường kính, tính bán kính, chu vi, diện tích hình tròn
            //float d;
            //Console.Write("nhap duong kinh: ");
            //d = float.Parse(Console.ReadLine());
            //Console.WriteLine("ban kinh: {0}", d / 2);
            //Console.WriteLine("chu vi: {0}", 3.14 * d);
            //Console.WriteLine("dien tich: {0}", 3.14 * (d / 2) * (d / 2));

            // Bài 4: nhập học sinh(họ tên, lớp, TBHK1, TBHK2), tính trung bình cả năm
            //string ten,lop;
            //float tbHK1, tbHK2;
            //Console.Write("nhap ten: ");
            //ten = Console.ReadLine();
            //Console.Write("nhap lop: ");
            //lop = Console.ReadLine();
            //Console.Write("nhap diem trung binh HK1: ");
            //tbHK1 = float.Parse (Console.ReadLine());
            //Console.Write("nhap diem trung binh HK2: ");
            //tbHK2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("diem trung binh ca nam cua {0} lop {1} la {2}", ten, lop, (tbHK1 + 2 * tbHK2) / 3);

            // chưa làm được
            //Bài 5: nhập hai nhân viên(tên, giới, ngày sinh, hs lương, lương cb, số năm làm việc, phụ cấp)
            //string tenNV, gioi;
            //DateTime nSinh;
            //int thamNien;
            //float hsLuong, luongCB, phuCap;
            //Console.Write("nhap ten: ");
            //tenNV = Console.ReadLine();
            //Console.Write("nhap gioi tinh: ");
            //gioi = Console.ReadLine();
            //Console.Write("nhap ngay sinh ");
            //nSinh = DateTime.Parse(Console.ReadLine());
            //Console.Write("nhap luong can ban: ");
            //luongCB = int.Parse(Console.ReadLine());
            //Console.Write("nhap he so luong: ");
            //hsLuong = int.Parse(Console.ReadLine());
            //Console.Write("nhap tham nien: ");
            //thamNien = int.Parse(Console.ReadLine());
            //phuCap = thamNien >= 5 ? luongCB / 2 : 0;
            //Console.WriteLine("tham nien: {0} nam", thamNien);

            // Bài 6: nhập ngày tháng năm, hiển thị hôm qua và ngày mai
            //int ngay, thang, nam;
            //Console.Write("nhap ngay: ");
            //ngay = int.Parse(Console.ReadLine());
            //Console.Write("nhap thang: ");
            //thang = int.Parse(Console.ReadLine());
            //Console.Write("nhap nam: ");
            //nam = int.Parse(Console.ReadLine());
            //DateTime date = new DateTime(nam, thang, ngay);
            //Console.WriteLine("hom qua la {0}", date.AddDays(-1).ToString("dd/MM/yyyy"));
            //Console.WriteLine("hom nay la {0}", date.ToString("dd/MM/yyyy"));
            //Console.WriteLine("ngay mai la {0}", date.AddDays(1).ToString("dd/MM/yyyy"));

            Console.ReadKey();
        }
    }
}
