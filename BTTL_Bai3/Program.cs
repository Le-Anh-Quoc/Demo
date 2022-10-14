using System;

namespace BTTL_Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 0;
            while (i <= 10)
            {
                while (j <= 9)
                {
                    Console.WriteLine(i + " x " + j + " = " + (i * j));
                    j++;
                }
                Console.WriteLine();
                j = 0;
                i++;
            }
        }
    }
}
