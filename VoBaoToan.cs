using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoBaoToan
{
    //1) tạo lớp todo
    public class Todo
    {
        // a) tên việc cần làm
        public string NameOfWork { get; set; }
        // b) độ ưu tiên
        public int Priority { get; set; }// 1-> 5, 1 là độ ưu tiên thấp nhất
        // c) mô tả cụ thể
        public string Detail { get; set; }
        // d) trạng thái
        public int Status { get; set; }//0: hủy; 1: hoàn thành; 2: chờ
        // constructor
        public Todo(string nameOfWork, int priority, string detail, int status)
        {
            NameOfWork = nameOfWork;
            Priority = priority;
            Detail = detail;
            Status = status;
        }
        private string StatusRef(int Status)
        {
            string text = "";
            switch(Status)
            {
                case 0:
                    text = "huy";
                    break;
                case 1:
                    text = "hoan thanh";
                    break;
                case 2:
                    text = "cho";
                    break;
            }
            return text;
        }
        public void InRaTodo() 
        {
            Console.WriteLine("\tten: {0}", NameOfWork);
            Console.WriteLine("\tdo uu tien: {0}", Priority);
            Console.WriteLine("\tchi tiet: {0}", Detail);
            Console.WriteLine("\ttrang thai: {0}", StatusRef(Status));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todoList = new List<Todo>();
            todoList.Add(new Todo ( "rua chen", 2, "rua dong chen hom qua con de lai", 2 ));
            todoList.Add(new Todo ("giat do", 3, "mot tuan roi chua giat, phai giat lien", 1));
            todoList.Add(new Todo ("nau com", 1, "nau com de sang mang theo", 0));
            todoList.Add(new Todo("cho ga an", 4, "", 0));
            bool quit = false;
            while (!quit)
            {
                int chon = InMenu();
                switch (chon)
                {
                    case (int)'1':// them
                        todoList.Add(AddWork());
                        break;
                    case (int)'2':// xoa
                        DeleteWork(ref todoList);
                        break;
                    case (int)'3':// sua
                        ChangeStatus(ref todoList);
                        break;
                    case (int)'4':// tim kiem
                        SearchWork(todoList);
                        break;
                    case (int)'5':// hien thi theo do uu tien giam dan
                        ShowAllWorkByPriorityOrder(todoList);
                        break;
                    case (int)'6':// hien thi toan bo
                        ShowAllWork(todoList);
                        break;
                    //
                    case 27:// phim Escape
                    case (int)'q':
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("lua chon chua dung");
                        break;
                }
            }
            //Console.ReadKey();
        }
        public static int InMenu()
        {
            Console.WriteLine("----To do LiSt----");
            Console.WriteLine("1: them cong viec");
            Console.WriteLine("2: xoa cong viec");
            Console.WriteLine("3: sua trang thai");
            Console.WriteLine("4: tim kiem cong viec");
            Console.WriteLine("5: hien thi theo do uu tien giam dan");
            Console.WriteLine("6: hien thi toan bo");
            Console.WriteLine("q hoac escape: thoat");
            Console.Write("lua chon: ");
            ConsoleKeyInfo key = Console.ReadKey(false);
            int chon = (int)key.KeyChar;
            return chon;
        }
        static Todo AddWork()
        {
            string name;
            {
                Console.Write("\nNhap ten Cong Viec: ");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                    Console.WriteLine("Ten viec khong duoc de trong.");
            } while (string.IsNullOrEmpty(name)) ;

            int priority;
            do
            {
                Console.Write("Do uu tien (1-5): ");
                priority = int.Parse(Console.ReadLine());
                if (priority < 1 || priority > 5)
                    Console.WriteLine("chi nhan gia tri tu 1 - 5");
            } while (priority < 1 || priority > 5);

            Console.Write("chi tiet cong viec: ");
            string detail = Console.ReadLine();

            int status;
            do
            {
                Console.Write("trang thai (0: Huy, 1: hoan thanh, 2: Cho): ");
                status = int.Parse(Console.ReadLine());
                if (status < 0 || status > 2)
                    Console.WriteLine("chi nhan gia tri tu 0 den 2");
            } while (status < 0 || status > 2);
            Console.WriteLine("Da them");
            Todo work = new Todo(name, priority, detail, status);
            return work;
        }
        public static void DeleteWork(ref List<Todo> todoList)
        {
            int idx;
            do
            {
                Console.Write("\nnhap vi tri cua cong viec muon xoa");
                idx = int.Parse(Console.ReadLine());
                if (idx < 0 || idx > todoList.Count)
                    Console.WriteLine("khong tim thay cong viec tai vi tri {0}", idx);
            } while (idx < 0 || idx > todoList.Count);
            todoList.RemoveAt(idx);
        }

        public static void ChangeStatus(ref List<Todo> todoList)
        {
            int idx;
            do
            {
                Console.Write("\nnhap vi tri cua cong viec muon cap nhat trang thai");
                idx = int.Parse(Console.ReadLine());
                if (idx < 0 || idx > todoList.Count)
                    Console.WriteLine("khong tim thay cong viec tai vi tri {0}", idx);
            } while (idx < 0 || idx > todoList.Count);
            int status;
            do
            {
                Console.Write("trang thai (0: Huy, 1: hoan thanh, 2: Cho): ");
                status = int.Parse(Console.ReadLine());
                if (status < 0 || status > 2)
                    Console.WriteLine("chi nhan gia tri tu 0 den 2");
            } while (status < 0 || status > 2);
            todoList[idx].Status = status;
            Console.WriteLine("vi tri {0}:", idx);
            todoList[idx].InRaTodo();
        }
        static void SearchWork(List<Todo> todoList)
        {
            Console.Write("\nten viec can tim: ");
            string searchtxt = Console.ReadLine();

            List<Todo> result = todoList.Where(t => t.NameOfWork.Contains(searchtxt)).ToList();
            Console.WriteLine("Ket qua tim kiem: ");
            if (result.Count > 0)
                result.ForEach(t => t.InRaTodo());
            else
                Console.WriteLine("Khong tim thay");
        }
        static void ShowAllWorkByPriorityOrder(List<Todo> todoList)
        {
            Console.WriteLine("");
            List<Todo> result = todoList.OrderByDescending(t => t.Priority).ToList();
            ShowAllWork(result);
        }
        static void ShowAllWork(List<Todo> todoList)
        {
            Console.WriteLine("");
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine("vi tri: {0}", i);
                todoList[i].InRaTodo();
            }
        }
    }
}
