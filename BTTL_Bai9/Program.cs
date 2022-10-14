using System;

namespace BTTL_Bai8
{
    class Program
    {
        static bool soNguyenTo(int a)
        {
            bool flag = true;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    flag = false;
                }
            }
            if (flag == true)
            {
                return true;
            } else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap vao n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                if (soNguyenTo(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
