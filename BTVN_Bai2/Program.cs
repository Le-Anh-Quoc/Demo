using System;

namespace BTVN_Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 99; i++)
            {
                if (i % 11 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
