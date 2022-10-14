using System;

namespace BTVN_Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
