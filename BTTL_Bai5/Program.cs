using System;

namespace BTTL_Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, r;
            Console.Write("Moi nhap chieu dai: ");
            d = int.Parse(Console.ReadLine());
            Console.Write("Moi nhap chieu rong: ");
            r = int.Parse(Console.ReadLine());
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
