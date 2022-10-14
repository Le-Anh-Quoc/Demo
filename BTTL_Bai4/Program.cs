using System;

namespace BTTL_Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 0;
            while (i <= 10)
            {
                Console.WriteLine();
                while (j <= 10)
                {
                    Console.Write(j + " x " + i + " = " + (i * j) + "    ");
                    j++;
                }
                j = 0;
                i++;
            }
        }
    }
}
