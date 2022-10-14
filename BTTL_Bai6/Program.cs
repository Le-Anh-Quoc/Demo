using System;

namespace BTTL_Bai6
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
                    if (i == 0 || i == r - 1)
                    {
                        Console.Write("*");
                    } else
                    {
                        if (j == 0 || j == d - 1)
                        {
                            Console.Write("*");
                        } else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
