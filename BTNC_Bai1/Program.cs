using System;

namespace BTNC_Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Nhap a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            c = double.Parse(Console.ReadLine());
            //Nhap a, b, c
            //Tinh nang
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh co vo so nghiem.");
                    } else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem.");
                    }
                } else
                {
                    double x = -(c / b);
                    Console.WriteLine("Phuong trinh co mot nghiem la: " + x);
                }
            } else
            {
                double delta = (b * b) - (4 * a * c);
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                } else if (delta == 0)
                {
                    double x = -(b / (2 * a));
                    Console.WriteLine("Phuong trinh co nghiem kep la: ", x);
                    //Phuong trinh co nghiem kep la
                    //khong can comment nay dau
                } else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Nghiem thu nhat la: " + x1);
                    Console.WriteLine("Nghiem thu hai la: " + x2);
                }
            }
        }
    }
}
