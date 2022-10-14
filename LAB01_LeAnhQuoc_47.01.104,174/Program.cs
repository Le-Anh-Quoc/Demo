using System;

namespace BTTL_Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            float dongia, soluong;
            Console.Write("Nhap vao don gia cua mat hang: ");
            dongia = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao so luong cua mat hang: ");
            soluong = float.Parse(Console.ReadLine());
            double thanhtien = dongia * soluong;
            double giamgia;
            if (thanhtien > 100)
            {
                giamgia = thanhtien * 0.03;
            } else
            {
                giamgia = 0;
            }
            Console.WriteLine("Tong tien phai tra: " + (thanhtien - giamgia));
        }
    }
}
