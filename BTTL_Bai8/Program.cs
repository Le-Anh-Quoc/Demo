using System;

namespace BTTL_Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool flag = true;
            Console.Write("Nhap vao n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    flag = false;
                }
            }
            if (flag == false || n < 2) {
                Console.WriteLine("n khong phai la mot so nguyen to.");
            } else
            {
                Console.WriteLine("n la mot so nguyen to.");
            }
        }
    }
}
