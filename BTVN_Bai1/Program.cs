using System;

namespace BTVN_Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban chon bai (a hoac b): ");
            char n = char.Parse(Console.ReadLine());
            Console.WriteLine("Dien gia tri cho x: ");
            double x = double.Parse(Console.ReadLine());
            if (n == 'a')
            {
                if (x > 0)
                {
                    Console.WriteLine("Gia tri ham cua bai a: " + ((3*x) + Math.Sqrt(x)));
                } else
                {
                    Console.WriteLine("Gia tri ham cua bai a: " + (Math.Pow(Math.E, x) + 4));
                }
            } else if (n == 'b')
            {
                if (x >= 1)
                {
                    Console.WriteLine("Gia tri ham cua bai b: " + (Math.Sqrt(Math.Pow(x, 2) + 1)));
                } else if (x > -1 && x < 1)
                {
                    Console.WriteLine("Gia tri ham cua bai b: " + ((3 * x) + 5));
                } else
                {
                    Console.WriteLine("Gia tri ham cua bai b: " + (Math.Pow(x,2) + (2 * x) - 1));
                }
            }
        }
    }
}
