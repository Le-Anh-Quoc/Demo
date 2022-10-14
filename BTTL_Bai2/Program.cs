using System;

namespace BTTL_Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int kwDien;
            int tiendien = 0;
            int temp;
            Console.Write("Moi nhap vao so KW dien: ");
            kwDien = int.Parse(Console.ReadLine());
            while (kwDien > 0)
            {
                if (kwDien <= 100)
                {
                    tiendien += kwDien * 5;
                    kwDien -= kwDien;
                } else if (kwDien <= 150)
                {
                    temp = kwDien - 100;
                    tiendien += temp * 7;
                    kwDien -= temp;
                } else if (kwDien <= 200)
                {
                    temp = kwDien - 150;
                    tiendien += temp * 10;
                    kwDien -= temp;
                } else if (kwDien <= 300)
                {
                    temp = kwDien - 200;
                    tiendien += temp * 15;
                    kwDien -= temp;
                } else
                {
                    temp = kwDien - 300;
                    tiendien += temp * 20;
                    kwDien -= temp;
                }
            }
            Console.WriteLine("Tien dien can phai tra la: " + tiendien);
        }
    }
}
