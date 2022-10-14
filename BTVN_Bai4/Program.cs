using System;

namespace BTVN_Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap m: ");
            int m = int.Parse(Console.ReadLine());
            for (int i = n; i <= m; i++)
            {
                if (i % 2 == 0)
                {
                    count += 1;
                }
            }
            Console.WriteLine("So luong so chan tu " + n + " den " + m + " la: " + count);
        }
    }
}
