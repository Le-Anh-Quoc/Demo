using System;

namespace BTNC_Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chieu cao cua tam giac can: ");
            int h = int.Parse(Console.ReadLine());
            int i = 1, v = 1;
            //tach code ra de nhin
            while (i <= h)
            {
                for (int j = 1; j <= h - i; j++)
                {
                    Console.Write(" ");
                }
                if (i < h)
                {
                    for (int j = 1; j <= v; j++)
                    {
                        if (j > 1 && j < v)
                        {
                            Console.Write(" ");
                        } else
                        {
                            Console.Write("*");
                        }
                    }
                } else
                {
                    for (int j = 1; j <= v; j++)
                    {
                        Console.Write("*");
                    }
                }

                for (int j = 1; j <= h - i; j++)
                {
                    Console.Write(" ");
                }
                if (i < h)
                {
                    Console.WriteLine();
                }
                i++;
                v += 2;
            }
        }
    }
}
