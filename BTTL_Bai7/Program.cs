using System;

namespace BTTL_Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double tong = 0;
            Console.Write("Nhap vao n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                tong += Math.Pow(i, 2);
            }
            Console.WriteLine(tong);
        }
    }
}
