using System;

namespace BTTL_Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int n = 1;
            int temp = 0;
            while (n != 0)
            {
                n = int.Parse(Console.ReadLine());
                if (n != 0)
                {
                    a[temp++] = n;
                }
            }

            int tong = 0;
            for (int i = 0; i < temp; i++)
            {
                tong += a[i];
            }
            Console.WriteLine("Tong cua day so tren la:" + tong);
            int max = a[0];
            for (int i = 1; i < temp; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine("So lon nhat cua day so tren la:" + max);

            int min = a[0];
            for (int i = 1; i < temp; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            Console.WriteLine("So nho nhat cua day so tren la:" + min);
        }
    }
}
